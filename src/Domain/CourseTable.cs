using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace CourseCrawler
{
    internal class CourseTable : Bindable, ICourseTable
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

        private string _name;
        private BindingList<ICourse> _courses;

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }
        public BindingList<ICourse> Courses
        {
            get => _courses;
            set => SetField(ref _courses, value);
        }

        public bool IsAnyCourseSelected => _courses.Any(course => course.IsSelected);
    }
}
