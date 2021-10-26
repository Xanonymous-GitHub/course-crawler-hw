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

        }

        private List<ICourse> _courses;

        public List<ICourse> CoursesToBeEdit
        {
            get => _courses;
            set => SetField(ref _courses, value);
        }

        public void LoadCourses()
        {

        }
    }
}
