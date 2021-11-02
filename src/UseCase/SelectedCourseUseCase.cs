using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class SaveSelectedCourseUseCase : IUseCase<bool>
    {
        public SaveSelectedCourseUseCase(BindingList<ICourse> selectedCourses)
        {
            _selectedCourses = selectedCourses;
        }

        private readonly BindingList<ICourse> _selectedCourses;

        private readonly Store _store = Store.Instance;

        // Do this usecase
        public bool Do()
        {
            _store.Update(Consts.SelectedCourse, _selectedCourses);
            return true;
        }
    }

    internal sealed class GetSelectedCourseUseCase : IUseCase<BindingList<ICourse>>
    {
        public GetSelectedCourseUseCase() { }

        private readonly Store _store = Store.Instance;

        // Do this usecase
        public BindingList<ICourse> Do()
        {
            return _store.Use<BindingList<ICourse>>(Consts.SelectedCourse);
        }
    }
}
