namespace CourseCrawler
{
    internal sealed class GetDepartmentUseCase : IUseCase<Department>
    {
        public GetDepartmentUseCase(string departmentName)
        {
            _departmentName = departmentName;
        }

        private readonly string _departmentName;

        private readonly Store _store = Store.Instance;

        // Do this usecase
        public Department Do()
        {
            bool hasSettedUpDepartment = _store.Exist(Constants.AllDepartments);

            if (!hasSettedUpDepartment) return null;

            ObservableDictionary<string, Department> allDepartments = _store.Use<ObservableDictionary<string, Department>>(Constants.AllDepartments);

            if (!allDepartments.ContainsKey(_departmentName)) return null;

            return allDepartments[_departmentName];
        }
    }
}
