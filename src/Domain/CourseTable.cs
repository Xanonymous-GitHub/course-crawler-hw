using System.Collections.Generic;
using System.Linq;

namespace CourseCrawler
{
    internal class CourseTable : ICourseTable
    {
        public CourseTable(string name, List<ICourse> courses)
        {
            _name = name;
            _courses = courses;
        }

        public CourseTable(string name, ICourse course)
        {
            _name = name;
            List<ICourse> courses = new();
            courses.Add(course);
            _courses = courses;
        }

        private readonly string _name;
        private readonly List<ICourse> _courses;

        public string Name => _name;
        public List<ICourse> Courses => _courses;

        public bool IsAnyCourseSelected => _courses.Any(course => course.IsSelected);
    }
}
