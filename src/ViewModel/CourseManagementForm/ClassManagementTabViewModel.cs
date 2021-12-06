using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    public sealed class ClassManagementTabViewModel
    {
        public ClassManagementTabViewModel()
        {
            DepartmentNamesToShow = new();
        }

        private readonly Store _store = Store.Instance;
        public List<string> DepartmentNamesToShow;

        // GenerateClassList
        public void GenerateClassList()
        {
            List<string> supportedDepartmentFullNames = SupportedDataSourceInfo.GetAllCombinedNames;

            if (_store.Exist(Consts.NewClasses))
            {
                List<string> newAddedDepartmentFullNames = _store.Use<List<string>>(Consts.NewClasses);
                if (newAddedDepartmentFullNames != null)
                {
                    supportedDepartmentFullNames = supportedDepartmentFullNames.Concat(newAddedDepartmentFullNames).ToList();
                }
            }

            DepartmentNamesToShow.Clear();
            DepartmentNamesToShow = DepartmentNamesToShow.Concat(supportedDepartmentFullNames).ToList();
        }
    }
}
