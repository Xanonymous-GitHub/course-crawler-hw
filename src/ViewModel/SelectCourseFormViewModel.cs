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

        public bool IsLastOperationHasIncreasedCourseCheckedAmount = false;

        private int _currentDisplayedTableNameHash;

        private string _currentDepartmentName, _currentTableName;

        private readonly Dictionary<int, CourseTable> _cachedTables = new();

        private readonly SortedDictionary<int, List<bool>> _courseTableCheckedStates = new();

        public void ChangeDisplayTable(string departmentName, string tableName)
        {
            int nextDisplayedTableNameHash = (departmentName + tableName).GetHashCode();

            if (_currentDisplayedTableNameHash == nextDisplayedTableNameHash) return;
            
            if (!_cachedTables.ContainsKey(nextDisplayedTableNameHash))
            {
                GetCourseTableUseCase getTableUseCase = new(departmentName, tableName);
                CourseTable newTable = getTableUseCase.Do();

                if (newTable == null) return;

                _cachedTables.Add(nextDisplayedTableNameHash.GetHashCode(), newTable);
                _courseTableCheckedStates.Add(nextDisplayedTableNameHash, new List<bool>(newTable.Courses.Count));
            }

            _currentDepartmentName = departmentName;
            _currentTableName = tableName;
            _currentDisplayedTableNameHash = (_currentDepartmentName + _currentTableName).GetHashCode();
        }

        public List<string[]> GetCourseTableRows()
        {
            return CourseTableDto.FromTableToRows(_cachedTables[_currentDisplayedTableNameHash]);
        }

        public bool IsAnyCourseChecked()
        {
            if (IsLastOperationHasIncreasedCourseCheckedAmount) return true;

            foreach (KeyValuePair<int, List<bool>> kvp in _courseTableCheckedStates)
            {
                if (kvp.Value.Any(state => state)) return true;
            }

            return false;
        }

        public bool IsAnyCourseSelected()
        {
            foreach (KeyValuePair<int, CourseTable> kvp in _cachedTables)
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

            foreach (KeyValuePair<int, CourseTable> kvp in _cachedTables)
            {
                foreach (dynamic course in kvp.Value.Courses.Select((value, index) => new { value, index }))
                {
                    if (_courseTableCheckedStates[kvp.Key][course.index]) checkedCourse.Add(course.value);
                }
            }

            return checkedCourse;
        }

        public Result<string> HandleSelectCourseSubmission()
        {
            List<Course> checkedCourse = GetCheckedCourse();
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
                    if (weekTime.Times == null) continue;

                    foreach (string time in weekTime.Times)
                    {
                        string classifyKey = weekTime.Name + Constants.SpaceChar + time;
                        if (!courseClassifiedByTime.ContainsKey(classifyKey))
                        {
                            courseClassifiedByTime[classifyKey] = new();
                        }
                        courseClassifiedByTime[classifyKey].Add(course);
                    }
                }
            }

            string nameConflictErrMsg = null;
            string timeConflictErrMsg = null;

            foreach (KeyValuePair<string, List<Course>> kvp in courseClassifiedByName)
            {
                if (kvp.Value.Count < 2) continue;
                if (nameConflictErrMsg != null) nameConflictErrMsg += Constants.Comma;
                nameConflictErrMsg += string.Join(
                    Constants.IdeographicComma,
                    kvp.Value.Select(course => 
                        Constants.UpperQuoteTw + 
                        CourseDto.ToNumberAndName(course) + 
                        Constants.LowerQuoteTw
                    ).ToArray()
                );
            }

            foreach (KeyValuePair<string, List<Course>> kvp in courseClassifiedByTime)
            {
                if (kvp.Value.Count < 2) continue;
                if (timeConflictErrMsg != null) timeConflictErrMsg += Constants.Comma;
                timeConflictErrMsg += string.Join(
                    Constants.IdeographicComma,
                    kvp.Value.Select(course =>
                        Constants.UpperQuoteTw +
                        CourseDto.ToNumberAndName(course) +
                        Constants.LowerQuoteTw
                    ).ToArray()
                );
            }

            if (nameConflictErrMsg == null && timeConflictErrMsg == null)
            {
                return new SuccessResult<string>(Constants.SuccessfullySelectCourse);
            }

            nameConflictErrMsg = Constants.NameConflictErrMsgHead + nameConflictErrMsg;
            timeConflictErrMsg = Constants.TimeConflictErrMsgHead + timeConflictErrMsg;

            return new ErrorResult<string>
            (
                Constants.FailToSelectCourse +
                timeConflictErrMsg.ToString() +
                nameConflictErrMsg.ToString()
            );
        }
    }
}
