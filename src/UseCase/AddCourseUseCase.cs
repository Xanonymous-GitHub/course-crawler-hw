using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CourseCrawler
{
    internal sealed class AddCourseUseCase : IUseCase<bool>
    {
        public AddCourseUseCase(int dataSourceIndex, ICourse course)
        {
            _dataSourceIndex = dataSourceIndex;
            _course = course;
        }

        private readonly int _dataSourceIndex;
        private readonly ICourse _course;

        // Do this usecase
        public bool Do()
        {
            GetCourseTableUseCase getCourseTableUseCase = new(_dataSourceIndex);
            CourseTable courseTable = getCourseTableUseCase.Do();

            int courseIndexInTable = courseTable.Courses.ToList().FindIndex(course => course.GetHashCode() == _course.GetHashCode());
            if (courseIndexInTable != -1) throw new Exception(Consts.MsgElementShouldNotBeFound);

            courseTable.Courses.Add(_course);

            // TODO: Make ObservableDictionary auto detect the propertyChanged event from its child when they are a complex structure (ex. List).
            courseTable.DirectlyNotifyPropertyChanged(nameof(courseTable.Courses));

            string departmentName = SupportedDataSourceInfo.GetDepartmentName(_dataSourceIndex);
            GetDepartmentUseCase getDepartmentUseCase = new(departmentName);
            getDepartmentUseCase.Do().DirectlyNotifyPropertyChanged();

            GetAllDepartmentsUseCase getAllDepartmentsUseCase = new();
            getAllDepartmentsUseCase.Do().DirectlyNotifyPropertyChanged();

            return false;
        }
    }
}
