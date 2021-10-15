namespace CourseCrawler
{
    internal sealed class GetCourseTableUseCase : IUseCase<CourseTable>
    {
        public GetCourseTableUseCase(string departmentName, string tableName)
        {
            _departmentName = departmentName;
            _tableName = tableName;
        }

        private readonly string _departmentName, _tableName;

        public CourseTable Do()
        {
            GetDepartmentUseCase getDepartmentUseCase = new(_departmentName);
            Department department = getDepartmentUseCase.Do();

            if (department != null)
            {
                bool hasTable = department.CourseTables.TryGetValue(_tableName, out ICourseTable table);
                if (hasTable) return (CourseTable)table;
            }

            FetchDepartmentCourseTableUseCase fetchDepartmentCourseTableUseCase = new(_departmentName, _tableName);
            department = fetchDepartmentCourseTableUseCase.Do();
            if (department == null) return null;

            return (CourseTable)department.CourseTables[_tableName];
        }
    }
}
