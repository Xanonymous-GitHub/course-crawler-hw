﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CourseCrawler
{
    internal sealed class UpdateCourseUseCase : IUseCase<bool>
    {
        public UpdateCourseUseCase(int dataSourceIndex, ICourse originCourse, ICourse newCourse)
        {
            _dataSourceIndex = dataSourceIndex;
            _originCourse = originCourse;
            _newCourse = newCourse;
        }

        private readonly int _dataSourceIndex;
        private readonly ICourse _originCourse, _newCourse;

        // Do this usecase
        public bool Do()
        {
            GetCourseTableUseCase getCourseTableUseCase = new(_dataSourceIndex);
            CourseTable courseTable = getCourseTableUseCase.Do();

            int courseIndexInTable = courseTable.Courses.ToList().FindIndex(course => course.GetHashCode() == _originCourse.GetHashCode());
            if (courseIndexInTable == -1) throw new Exception(Consts.MsgElementNotFound);

            courseTable.Courses[courseIndexInTable] = _newCourse;
            courseTable.DirectlyNotifyPropertyChanged(nameof(courseTable.Courses));

            return false;
        }
    }
}
