using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler
{
    public sealed class GetAllCourseUseCase : IUseCase<List<BindingList<ICourse>>>
    {
        private readonly GetAllDepartmentsUseCase _getAllDepartmentsUseCase = new();

        // Do this usecase
        public List<BindingList<ICourse>> Do()
        {
            ObservableDictionary<string, Department> allDepartments = _getAllDepartmentsUseCase.Do();
            if (allDepartments == null) return null;

            List<BindingList<ICourse>> allCourses = new(SupportedDataSourceInfo.Amount);

            for (int i = 0; i < SupportedDataSourceInfo.Amount; i++)
            {
                GetCourseTableUseCase getCourseTableUseCase = new(i);
                CourseTable table = getCourseTableUseCase.Do();
                allCourses.Add(new());
                foreach (ICourse Course in table.Courses)
                {
                    allCourses.Last().Add(Course);
                }
            }

            return allCourses;
        }
    }
}
