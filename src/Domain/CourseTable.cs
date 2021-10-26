using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace CourseCrawler
{
    internal class CourseTable : ICourseTable
    {
        public CourseTable(string name, List<ICourse> courses)
        {
            _name = name;
            _courses = new(courses);
        }

        public CourseTable(string name, BindingList<ICourse> courses)
        {
            _name = name;
            _courses = courses;
        }

        public CourseTable(string name, ICourse course)
        {
            _name = name;
            BindingList<ICourse> courses = new();
            courses.Add(course);
            _courses = courses;
        }

        private readonly string _name;
        private readonly BindingList<ICourse> _courses;

        public string Name => _name;
        public BindingList<ICourse> Courses => _courses;

        public bool IsAnyCourseSelected => _courses.Any(course => course.IsSelected);
    }
}
