using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class CourseManagementFormViewModel : Bindable
    {
        public CourseManagementFormViewModel()
        {
            LoadCourses();
        }

        private BindingList<ICourse> _courses;

        public BindingList<ICourse> CoursesToBeEdit
        {
            get => _courses;
            set => SetField(ref _courses, value);
        }

        public List<string> CoursesToBeEditStr => CoursesToBeEdit.Select(course => course.Name).ToList();

        // LoadCourses
        public void LoadCourses()
        {
            GetAllCourseUseCase getAllCourseUseCase = new();
            CoursesToBeEdit = getAllCourseUseCase.Do();
        }
    }
}
