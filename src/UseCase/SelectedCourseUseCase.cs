using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class SaveSelectedCourseUseCase : IUseCase<bool>
    {
        public SaveSelectedCourseUseCase(List<ICourse> selectedCourses)
        {
            _selectedCourses = selectedCourses;
        }

        private readonly List<ICourse> _selectedCourses;

        private readonly Store _store = Store.Instance;

        public bool Do()
        {
            _store.Update(Constants.SelectedCourse, _selectedCourses);
            return true;
        }
    }

    internal sealed class GetSelectedCourseUseCase : IUseCase<List<ICourse>>
    {
        public GetSelectedCourseUseCase() { }

        private readonly Store _store = Store.Instance;

        public List<ICourse> Do()
        {
            return _store.Use<List<ICourse>>(Constants.SelectedCourse);
        }
    }
}
