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
            CoursesToShow = new();
        }

        private readonly Store _store = Store.Instance;
        public List<string> DepartmentNamesToShow;
        public List<string> CoursesToShow;

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

        // GenerateCoursesByClassName
        public void GenerateCoursesByClassName(string className)
        {
            CoursesToShow.Clear();

            if (!SupportedDataSourceInfo.GetAllCombinedNames.Contains(className)) return;

            int dataSourceIndex = SupportedDataSourceInfo.GetAllCombinedNames.IndexOf(className);
            if (dataSourceIndex == -1) throw new KeyNotFoundException();

            GetCourseTableUseCase getCourseTableUseCase = new(dataSourceIndex);
            CourseTable courseTable = getCourseTableUseCase.Do();

            courseTable.Courses.ToList().ForEach(course => CoursesToShow.Add(course.Name));
        }

        public void AddNewClass(string className)
        {
            List<string> newAddedDepartmentFullNames;

            if (_store.Exist(Consts.NewClasses))
            {
                newAddedDepartmentFullNames = _store.Use<List<string>>(Consts.NewClasses);
                if (newAddedDepartmentFullNames == null) newAddedDepartmentFullNames = new();
            }
            else
            {
                newAddedDepartmentFullNames = new();
            }

            newAddedDepartmentFullNames.Add(className);
            _store.Update(Consts.NewClasses, newAddedDepartmentFullNames);
        }
    }
}
