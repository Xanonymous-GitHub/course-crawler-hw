using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace CourseCrawler
{
    internal sealed class SelectCourseFormViewModel : INotifyPropertyChanged
    {
        private SelectCourseFormViewModel(string departmentName, string tableName)
        {
            ChangeDisplayTable(departmentName, tableName);
        }

        private string _currentDisplayedTableNameHash;

        private string _currentDepartmentName, _currentTableName;

        private readonly Dictionary<string, CourseTable> _cachedTables = new();

        private readonly Dictionary<string, List<string[]>> _cachedshouldDisplayedtableRowsStr = new();

        private readonly SortedDictionary<string, List<bool>> _courseTableCheckedStates = new();

        private bool _displayedtableRowsDirty = true;

        public static SelectCourseFormViewModel Instance;

        public event PropertyChangedEventHandler PropertyChanged;

        // MarkAsDirty
        public void MarkAsDirty() => _displayedtableRowsDirty = true;

        // UseCreateBy
        public static SelectCourseFormViewModel UseCreateBy(string departmentName, string tableName)
        {
            if (Instance == null) Instance = new SelectCourseFormViewModel(departmentName, tableName);
            return Instance;
        }

        // Use the given departname & tablename to generate a course table then cached it.
        public void ChangeDisplayTable(string departmentName, string tableName)
        {
            string nextDisplayedTableNameHash = departmentName + tableName;

            if (_currentDisplayedTableNameHash == nextDisplayedTableNameHash) return;
            
            if (!_cachedTables.ContainsKey(nextDisplayedTableNameHash))
            {
                GetCourseTableUseCase getTableUseCase = new(departmentName, tableName);
                CourseTable newTable = getTableUseCase.Do();

                _cachedTables.Add(nextDisplayedTableNameHash, newTable);
                if (newTable == null) return;

                List<bool> checkStates = new(new bool[newTable.Courses.Count]);
                _courseTableCheckedStates.Add(nextDisplayedTableNameHash, checkStates);

                _displayedtableRowsDirty = true;
            }

            _currentDepartmentName = departmentName;
            _currentTableName = tableName;
            _currentDisplayedTableNameHash = _currentDepartmentName + _currentTableName;
        }

        // Convert current cached course table to string array with checkBox status.
        public List<string[]> GetCourseTableRows()
        {
            if (!_displayedtableRowsDirty) return _cachedshouldDisplayedtableRowsStr[_currentDisplayedTableNameHash];

            CourseTable currentTable = _cachedTables[_currentDisplayedTableNameHash];
            if (currentTable == null) return null;

            List<List<string>> tableRows = CourseTableDto.FromTableToRows(currentTable);
            List<List<string>> shouldDisplayedtableRows = new();
            List<int> selectedCourseIndex = GetSelectedCourseIndex();
            List<bool> currentCheckStates = _courseTableCheckedStates[_currentDisplayedTableNameHash];

            for (int i = 0; i < tableRows.Count; i++)
            {
                if (selectedCourseIndex.Contains(i)) continue;

                List<string> rowWithCheckState = new() { currentCheckStates[i].ToString() };
                foreach(string colValue in tableRows[i])
                {
                    rowWithCheckState.Add(colValue);
                }

                shouldDisplayedtableRows.Add(rowWithCheckState);
            }

            _displayedtableRowsDirty = false;

            List<string[]> shouldDisplayedtableRowsStr = shouldDisplayedtableRows.Count == 0 ? null : shouldDisplayedtableRows.Select(row => row.ToArray()).ToList();
            _cachedshouldDisplayedtableRowsStr[_currentDisplayedTableNameHash] = shouldDisplayedtableRowsStr;

            return shouldDisplayedtableRowsStr;
        }

        // Check if there's exist any checked checkBox in whole gridView.
        public bool IsAnyCourseChecked()
        {
            foreach (KeyValuePair<string, List<bool>> kvp in _courseTableCheckedStates)
            {
                if (kvp.Value.Any(state => state)) return true;
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
            List<int> selectedCourseIndex = GetSelectedCourseIndex();
            int visitedDisplayedIndexAmount = 0, currentPos = -1;

            while (visitedDisplayedIndexAmount < displayIndex + 1)
            {
                currentPos++;
                if (!selectedCourseIndex.Contains(currentPos)) visitedDisplayedIndexAmount++;
            }

            _courseTableCheckedStates[_currentDisplayedTableNameHash][currentPos] = isChecked;
        }

        // clear check status.
        public void MakeAllUnCheck()
        {
            foreach (string k in _courseTableCheckedStates.Keys)
            {
                for(int i = 0; i< _courseTableCheckedStates[k].Count; i++)
                {
                    _courseTableCheckedStates[k][i] = false;
                }
            }
        }

        // Get a List contains checked courses and selected but non-checked courses.
        private List<Course> GetCheckedCourse()
        {
            List<Course> checkedCourse = new();

            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (_courseTableCheckedStates[kvp.Key][course.index] || course.value.IsSelected)
                    {
                        checkedCourse.Add(course.value);
                    }
                }
            }

            return checkedCourse;
        }

        // Get a List contains non-checked and non-selected courses.
        private List<Course> GetUncheckedCourse()
        {
            List<Course> unCheckedCourse = new();

            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (!_courseTableCheckedStates[kvp.Key][course.index] && !course.value.IsSelected)
                    {
                        unCheckedCourse.Add(course.value);
                    }
                }
            }

            return unCheckedCourse;
        }

        // Get a List contains all selected course's display index of current displayed tab.
        public List<int> GetSelectedCourseIndex()
        {
            List<int> selectedStatus = new();
            List<ICourse> currentCourses = _cachedTables[_currentDisplayedTableNameHash].Courses;
            for (int i = 0; i < currentCourses.Count; i++)
            {
                if (currentCourses[i].IsSelected) selectedStatus.Add(i);
            }
            return selectedStatus;
        }

        // Make all given courses to selected state and save the selected course references to Store.
        private void SelectCourses(List<Course> courses)
        {
            List<ICourse> selectedCourses = new();
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
                    Constants.IdeographicComma,
                    kvp.Value.Select(course =>
                        Constants.UpperQuoteTw +
                        CourseDto.ToNumberAndName(course) +
                        Constants.LowerQuoteTw
                    ).ToArray()
                ));
            }
            return result.Count > 0 ? string.Join(Constants.Comma, result) : null;
        }

        // Verify all checked courses, check if there exist any conflicts of there properties, then make them become selected state.
        public Result<string> HandleSelectCourseSubmission()
        {
            List<Course> checkedCourse = GetCheckedCourse();
            List<Course> unCheckedCourse = GetUncheckedCourse();
            SortedDictionary<string, HashSet<Course>> courseClassifiedByName = new();
            SortedDictionary<string, HashSet<Course>> courseClassifiedByTime = new();

            foreach (Course course in checkedCourse)
            {
                if (!courseClassifiedByName.ContainsKey(course.Name))
                {
                    courseClassifiedByName[course.Name] = new();
                }
                courseClassifiedByName[course.Name].Add(course);

                foreach (WeekTime weekTime in course.WeekTimes)
                {
                    if (weekTime.Times == null || weekTime.Times[0] == string.Empty) continue;

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

            _displayedtableRowsDirty = true;

            if (nameConflictErrMsg == null && timeConflictErrMsg == null)
            {
                UnselectCourses(unCheckedCourse);
                SelectCourses(checkedCourse);
                MakeAllUnCheck();
                return new SuccessResult<string>(Constants.SuccessfullySelectCourse);
            }

            if (nameConflictErrMsg != null)
            {
                nameConflictErrMsg =
                    Constants.NewLineChar +
                    Constants.NameConflictErrMsgHead +
                    nameConflictErrMsg;
            }
            else
            {
                nameConflictErrMsg = string.Empty;
            }
            
            if (timeConflictErrMsg != null)
            {
                timeConflictErrMsg =
                    Constants.NewLineChar +
                    Constants.TimeConflictErrMsgHead + 
                    timeConflictErrMsg;
            }
            else
            {
                timeConflictErrMsg = string.Empty;
            }

            return new ErrorResult<string>
            (
                Constants.FailToSelectCourse +
                timeConflictErrMsg +
                nameConflictErrMsg
            );
        }
    }
}
