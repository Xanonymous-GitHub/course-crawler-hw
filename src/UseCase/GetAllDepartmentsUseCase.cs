namespace CourseCrawler
{
    internal sealed class GetAllDepartmentsUseCase : IUseCase<ObservableDictionary<string, Department>>
    {
        private readonly Store _store = Store.Instance;

        public ObservableDictionary<string, Department> Do()
        {
            if (!_store.Exist(Constants.AllDepartments)) return null;

            return _store.Use<ObservableDictionary<string, Department>>(Constants.AllDepartments);
        }
    }
}
