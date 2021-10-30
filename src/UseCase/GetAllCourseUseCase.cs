using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    internal sealed class GetAllCourseUseCase : IUseCase<List<BindingList<ICourse>>>
    {
        private readonly GetAllDepartmentsUseCase _getAllDepartmentsUseCase = new();

        // Do this usecase
        public List<BindingList<ICourse>> Do()
        {
            ObservableDictionary<string, Department> allDepartments = _getAllDepartmentsUseCase.Do();
            if (allDepartments == null) return null;

            List<BindingList<ICourse>> allCourses = new(SupportedDataSourceInfo.Amount);

            foreach (Department department in allDepartments.Values)
            {
                foreach (CourseTable table in department.CourseTables.Values)
                {
                    allCourses.Add(new());
                    foreach (ICourse Course in table.Courses)
                    {
                        allCourses.Last().Add(Course);
                    }
                }
            }

            return allCourses;
        }
    }
}
