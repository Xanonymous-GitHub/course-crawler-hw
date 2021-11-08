namespace CourseCrawler
{
    public sealed class GetAllDepartmentsUseCase : IUseCase<ObservableDictionary<string, Department>>
    {
        private readonly Store _store = Store.Instance;

        // Do this usecase
        public ObservableDictionary<string, Department> Do()
        {
            if (!_store.Exist(Consts.AllDepartments)) return null;

            return _store.Use<ObservableDictionary<string, Department>>(Consts.AllDepartments);
        }
    }
}
