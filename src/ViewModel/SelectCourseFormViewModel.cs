﻿using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace CourseCrawler
{
    internal sealed class SelectCourseFormViewModel : Bindable
    {
        private SelectCourseFormViewModel(int dataSourceIndex)
        {
            ChangeDisplayTable(dataSourceIndex);
            RegistryDepartmentPropertyChangedEventHandlers();
        }

        private string _currentDisplayedTableNameHash;

        private string _currentDepartmentName, _currentTableName;

        private readonly Dictionary<string, CourseTable> _cachedTables = new();

        public static SelectCourseFormViewModel Instance;

        private bool cacheAccessLocked = false;

        // UseCreateBy
        public static SelectCourseFormViewModel UseCreateBy(int dataSourceIndex)
        {
            if (Instance == null) Instance = new SelectCourseFormViewModel(dataSourceIndex);
            return Instance;
        }

        // RegistryDepartmentPropertyChangedEventHandlers
        public void RegistryDepartmentPropertyChangedEventHandlers()
        {
            GetAllDepartmentsUseCase getAllDepartmentsUseCase = new();
            getAllDepartmentsUseCase.Do().PropertyChanged += HandleDepartmentPropertyChanged;
        }

        // HandleDepartmentPropertyChanged
        public void HandleDepartmentPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            InvalidCaches();
            DirectlyNotifyPropertyChanged();
        }

        // InvalidCaches
        public void InvalidCaches()
        {
            _cachedTables.Clear();
        }

        // Use the given departname & tablename to generate a course table then cached it.
        public void ChangeDisplayTable(int dataSourceIndex)
        {
            string departmentName = SupportedDataSourceInfo.GetDepartmentName(dataSourceIndex);
            string tableName = SupportedDataSourceInfo.GetTableName(dataSourceIndex);
            string nextDisplayedTableNameHash = departmentName + tableName;
            
            if (!_cachedTables.ContainsKey(nextDisplayedTableNameHash) && !cacheAccessLocked)
            {
                cacheAccessLocked = true;
                GetCourseTableUseCase getTableUseCase = new(dataSourceIndex);
                CourseTable newTable = getTableUseCase.Do();

                _cachedTables.Add(nextDisplayedTableNameHash, newTable);

                cacheAccessLocked = false;
                if (newTable == null) return;
            }

            _currentDepartmentName = departmentName;
            _currentTableName = tableName;
            _currentDisplayedTableNameHash = _currentDepartmentName + _currentTableName;
        }

        // Convert current cached course table to string array with checkBox status.
        public List<string[]> GetCourseTableRows()
        {
            CourseTable currentTable = _cachedTables[_currentDisplayedTableNameHash];
            if (currentTable == null) return null;

            List<List<string>> tableRows = CourseTableDto.FromTableToRows(currentTable);
            List<List<string>> tableRowsForShow = new();
            List<int> selectedCourseIndex = GetSelectedCourseIndexes();
            
            for (int i = 0; i < tableRows.Count; i++)
            {
                if (selectedCourseIndex.Contains(i)) continue;

                List<string> rowWithCheckState = new() { currentTable.Courses[i].IsChecked.ToString() };
                foreach(string colValue in tableRows[i])
                {
                    rowWithCheckState.Add(colValue);
                }

                tableRowsForShow.Add(rowWithCheckState);
            }

            List<string[]> shouldDisplayedtableRowsStr = tableRowsForShow.Count == 0 ? null : tableRowsForShow.Select(row => row.ToArray()).ToList();

            return shouldDisplayedtableRowsStr;
        }

        // Check if there's exist any checked checkBox in whole gridView.
        public bool IsAnyCourseChecked()
        {
            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                if (kvp.Value.IsAnyCourseChecked) return true;
            }

            return false;
        }

        // Check if there's exist any Selected course in whole cachedTables.
        public bool IsAnyCourseSelected()
        {
            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                if (kvp.Value.IsAnyCourseSelected) return true;
            }

            return false;
        }

        // Change Course Check Status.
        public void ChangeCourseCheckStatus(int displayIndex, bool isChecked)
        {
            List<int> selectedCourseIndex = GetSelectedCourseIndexes();
            int visitedDisplayedIndexAmount = 0, currentPos = -1;

            while (visitedDisplayedIndexAmount < displayIndex + 1)
            {
                currentPos++;
                if (!selectedCourseIndex.Contains(currentPos)) visitedDisplayedIndexAmount++;
            }

            _cachedTables[_currentDisplayedTableNameHash].Courses[currentPos].IsChecked = isChecked;
        }

        // clear check status.
        public void MakeAllUnCheck()
        {
            foreach (string k in _cachedTables.Keys)
            {
                for(int i = 0; i< _cachedTables[k].Courses.Count; i++)
                {
                    _cachedTables[k].Courses[i].IsChecked = false;
                }
            }
        }

        // Get a List contains checked courses and selected but non-checked courses.
        private List<Course> GetCheckedCourses()
        {
            List<Course> checkedCourse = new();

            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (_cachedTables[kvp.Key].Courses[course.index].IsChecked || course.value.IsSelected)
                    {
                        checkedCourse.Add(course.value);
                    }
                }
            }

            return checkedCourse;
        }

        // Get a List contains non-checked and non-selected courses.
        private List<Course> GetUncheckedCourses()
        {
            List<Course> unCheckedCourse = new();

            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (!_cachedTables[kvp.Key].Courses[course.index].IsChecked && !course.value.IsSelected)
                    {
                        unCheckedCourse.Add(course.value);
                    }
                }
            }

            return unCheckedCourse;
        }

        // Get a List contains all selected course's display index of current displayed tab.
        public List<int> GetSelectedCourseIndexes()
        {
            List<int> selectedStatus = new();
            BindingList<ICourse> currentCourses = _cachedTables[_currentDisplayedTableNameHash].Courses;
            for (int i = 0; i < currentCourses.Count; i++)
            {
                if (currentCourses[i].IsSelected) selectedStatus.Add(i);
            }
            return selectedStatus;
        }

        // Make all given courses to selected state and save the selected course references to Store.
        private void SelectCourses(List<Course> courses)
        {
            BindingList<ICourse> selectedCourses = new();
            foreach (Course course in courses)
            {
                course.MakeSelected();
                selectedCourses.Add(course);
            }
            SaveSelectedCourseUseCase saveSelectedCourseUseCase = new(selectedCourses);
            saveSelectedCourseUseCase.Do();
        }

        // Make all given courses to unselected state.
        private void UnselectCourses(List<Course> courses)
        {
            foreach (Course course in courses)
            {
                course.MakeUnselected();
            }
        }

        // When there exist more than 2 courses in same Map Value, means they have some conflict property, then add its info to generate the error msg.
        private string GenerateConflictErrMsg(SortedDictionary<string, HashSet<Course>> classifiedDict)
        {
            HashSet<string> result = new();
            foreach (KeyValuePair<string, HashSet<Course>> kvp in classifiedDict)
            {
                if (kvp.Value != null && kvp.Value.Count < 2) continue;
                result.Add(string.Join(
                    Consts.IdeographicComma,
                    kvp.Value.Select(course =>
                        Consts.UpperQuoteTw +
                        CourseDto.ToNumberAndName(course) +
                        Consts.LowerQuoteTw
                    ).ToArray()
                ));
            }
            return result.Count > 0 ? string.Join(Consts.Comma, result) : null;
        }

        // Verify all checked courses, check if there exist any conflicts of there properties, then make them become selected state.
        public Result<string> HandleSelectCourseSubmission()
        {
            List<Course> checkedCourses = GetCheckedCourses();
            List<Course> unCheckedCourses = GetUncheckedCourses();
            SortedDictionary<string, HashSet<Course>> courseClassifiedByName = new();
            SortedDictionary<string, HashSet<Course>> courseClassifiedByTime = new();

            foreach (Course course in checkedCourses)
            {
                if (!courseClassifiedByName.ContainsKey(course.Name))
                {
                    courseClassifiedByName[course.Name] = new();
                }
                courseClassifiedByName[course.Name].Add(course);

                foreach (WeekTime weekTime in course.WeekTimes)
                {
                    if (weekTime.Times == null || weekTime.Times.Length == 0 || weekTime.Times[0] == string.Empty) continue;
                    foreach (string time in weekTime.Times)
                    {
                        string classifyKey = weekTime.Name + time;
                        if (!courseClassifiedByTime.ContainsKey(classifyKey))
                        {
                            courseClassifiedByTime[classifyKey] = new();
                        }
                        courseClassifiedByTime[classifyKey].Add(course);
                    }
                }
            }
            
            string nameConflictErrMsg = GenerateConflictErrMsg(courseClassifiedByName);
            string timeConflictErrMsg = GenerateConflictErrMsg(courseClassifiedByTime);

            if (nameConflictErrMsg == null && timeConflictErrMsg == null)
            {
                UnselectCourses(unCheckedCourses);
                SelectCourses(checkedCourses);
                MakeAllUnCheck();
                return new SuccessResult<string>(Consts.SuccessfullySelectCourse);
            }

            if (nameConflictErrMsg != null)
            {
                nameConflictErrMsg =
                    Consts.NewLineChar +
                    Consts.NameConflictErrMsgHead +
                    nameConflictErrMsg;
            }
            else
            {
                nameConflictErrMsg = string.Empty;
            }
            
            if (timeConflictErrMsg != null)
            {
                timeConflictErrMsg =
                    Consts.NewLineChar +
                    Consts.TimeConflictErrMsgHead + 
                    timeConflictErrMsg;
            }
            else
            {
                timeConflictErrMsg = string.Empty;
            }

            return new ErrorResult<string>
            (
                Consts.FailToSelectCourse +
                timeConflictErrMsg +
                nameConflictErrMsg
            );
        }
    }
}
