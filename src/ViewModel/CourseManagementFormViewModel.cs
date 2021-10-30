using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class CourseManagementFormViewModel : Bindable
    {
        public CourseManagementFormViewModel()
        {
            LoadCourses();
        }

        private List<BindingList<ICourse>> _coursesToBeEdit;

        public List<string> CoursesToBeEditStr
        {
            get => _coursesToBeEdit.Select(courses => courses.Select(course => course.Name).ToList()).ToList().SelectMany(x => x).ToList();
        }

        // LoadCourses
        public void LoadCourses()
        {
            for (int dataSourceIndex = 0; dataSourceIndex < SupportedDataSourceInfo.Amount; dataSourceIndex++)
            {
                GetCourseTableUseCase getCourseTableUseCase = new(dataSourceIndex);
                getCourseTableUseCase.Do();
            }

            GetAllCourseUseCase getAllCourseUseCase = new();
            _coursesToBeEdit = getAllCourseUseCase.Do();
        }

        public (int dataSourceIndex, ICourse course) GenerateEditableFieldContens(int selectedIndex)
        {
            (int groupIndex, int childIndex) = Utils.FindGroupIndexPairIn2dList(_coursesToBeEdit, selectedIndex);
            return (groupIndex, _coursesToBeEdit[groupIndex][childIndex]);
        }
    }
}
