namespace CourseCrawler
{
    public sealed class GetCourseTableUseCase : IUseCase<CourseTable>
    {
        public GetCourseTableUseCase(int supportedDataSourceIndex)
        {
            _supportedDataSourceIndex = supportedDataSourceIndex;
            _departmentName = SupportedDataSourceInfo.GetDepartmentName(_supportedDataSourceIndex);
            _tableName = SupportedDataSourceInfo.GetTableName(_supportedDataSourceIndex);
        }

        private readonly int _supportedDataSourceIndex;
        private readonly string _departmentName, _tableName;

        // Do this usecase
        public CourseTable Do()
        {
            GetDepartmentUseCase getDepartmentUseCase = new(_departmentName);
            Department department = getDepartmentUseCase.Do();

            if (department != null)
            {
                bool hasTable = department.CourseTables.TryGetValue(_tableName, out ICourseTable table);
                if (hasTable) return (CourseTable)table;
            }

            FetchDepartmentCourseTableUseCase fetchDepartmentCourseTableUseCase = new(_supportedDataSourceIndex);
            department = fetchDepartmentCourseTableUseCase.Do();
            if (department == null) return null;

            return (CourseTable)department.CourseTables[_tableName];
        }
    }
}
