using System.Collections.Generic;
using System.Linq;

namespace CourseCrawler
{
    internal sealed class SelectCourseFormViewModel
    {
        public SelectCourseFormViewModel(string departmentName, string tableName) 
        {
            ChangeDisplayTable(departmentName, tableName);
        }

        private string _currentDisplayedTableNameHash;

        private string _currentDepartmentName, _currentTableName;

        private readonly Dictionary<string, CourseTable> _cachedTables = new();

        private readonly SortedDictionary<string, List<bool>> _courseTableCheckedStates = new();

        public void ChangeDisplayTable(string departmentName, string tableName)
        {
            string nextDisplayedTableNameHash = departmentName + tableName;

            if (_currentDisplayedTableNameHash == nextDisplayedTableNameHash) return;
            
            if (!_cachedTables.ContainsKey(nextDisplayedTableNameHash))
            {
                GetCourseTableUseCase getTableUseCase = new(departmentName, tableName);
                CourseTable newTable = getTableUseCase.Do();

                if (newTable == null) return;

                _cachedTables.Add(nextDisplayedTableNameHash, newTable);

                List<bool> checkStates = new(new bool[newTable.Courses.Count]);
                _courseTableCheckedStates.Add(nextDisplayedTableNameHash, checkStates);
            }

            _currentDepartmentName = departmentName;
            _currentTableName = tableName;
            _currentDisplayedTableNameHash = _currentDepartmentName + _currentTableName;
        }

        public List<string[]> GetCourseTableRows()
        {
            return CourseTableDto.FromTableToRows(_cachedTables[_currentDisplayedTableNameHash]);
        }

        public bool IsAnyCourseChecked()
        {
            foreach (KeyValuePair<string, List<bool>> kvp in _courseTableCheckedStates)
            {
                if (kvp.Value.Any(state => state)) return true;
            }

            return false;
        }

        public bool IsAnyCourseSelected()
        {
            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                if (kvp.Value.IsAnyCourseSelected) return true;
            }

            return false;
        }

        public void ChangeCourseSelectionStatus(int index, bool isSelected)
        {
            _courseTableCheckedStates[_currentDisplayedTableNameHash][index] = isSelected;
        }

        private List<Course> GetCheckedCourse()
        {
            List<Course> checkedCourse = new();

            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (_courseTableCheckedStates[kvp.Key][course.index]) checkedCourse.Add(course.value);
                }
            }

            return checkedCourse;
        }

        private List<Course> GetUncheckedCourse()
        {
            List<Course> unCheckedCourse = new();

            foreach (KeyValuePair<string, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (!_courseTableCheckedStates[kvp.Key][course.index]) unCheckedCourse.Add(course.value);
                }
            }

            return unCheckedCourse;
        }

        private void SelectCourses(List<Course> courses)
        {
            foreach (Course course in courses)
            {
                course.MakeSelected();
            }
        }

        private void UnselectCourses(List<Course> courses)
        {
            foreach (Course course in courses)
            {
                course.MakeUnselected();
            }
        }

        private string GenerateConflictErrMsg(SortedDictionary<string, List<Course>> classifiedDict)
        {
            string result = null;
            foreach (KeyValuePair<string, List<Course>> kvp in classifiedDict)
            {
                if (kvp.Value != null && kvp.Value.Count < 2) continue;
                if (result != null) result += Constants.Comma;
                result += string.Join(
                    Constants.IdeographicComma,
                    kvp.Value.Select(course =>
                        Constants.UpperQuoteTw +
                        CourseDto.ToNumberAndName(course) +
                        Constants.LowerQuoteTw
                    ).ToArray()
                );
            }
            return result;
        }

        public Result<string> HandleSelectCourseSubmission()
        {
            List<Course> checkedCourse = GetCheckedCourse();
            List<Course> unCheckedCourse = GetUncheckedCourse();
            SortedDictionary<string, List<Course>> courseClassifiedByName = new();
            SortedDictionary<string, List<Course>> courseClassifiedByTime = new();

            foreach (Course course in checkedCourse)
            {
                if (!courseClassifiedByName.ContainsKey(course.Name))
                {
                    courseClassifiedByName[course.Name] = new();
                }
                courseClassifiedByName[course.Name].Add(course);

                foreach (WeekTime weekTime in course.WeekTimes)
                {
                    if (weekTime.Times == null || weekTime.Times[0] == "") continue;

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
                UnselectCourses(unCheckedCourse);
                SelectCourses(checkedCourse);
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
                nameConflictErrMsg = "";
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
                timeConflictErrMsg = "";
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
