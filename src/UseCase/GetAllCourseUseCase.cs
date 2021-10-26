using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class GetAllCourseUseCase : IUseCase<BindingList<ICourse>>
    {
        private readonly GetAllDepartmentsUseCase _getAllDepartmentsUseCase = new();

        public BindingList<ICourse> Do()
        {
            ObservableDictionary<string, Department> allDepartments = _getAllDepartmentsUseCase.Do();
            if (allDepartments == null) return null;

            BindingList<ICourse> allCourses = new();
            allCourses.RaiseListChangedEvents = false;

            foreach (Department department in allDepartments.Values)
            {
                foreach (CourseTable table in department.CourseTables.Values)
                {
                    foreach(ICourse Course in table.Courses)
                    {
                        allCourses.Append(Course);
                    }
                }
            }

            allCourses.RaiseListChangedEvents = true;
            return allCourses;
        }
    }
}
