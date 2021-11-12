using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler.Tests
{
    [TestClass()]
    public class CourseManagementFormViewModelTests
    {
        // CorrectlyCreateCourseManagementFormViewModel
        [TestMethod()]
        public void CorrectlyCreateCourseManagementFormViewModel()
        {
            // Given
            CourseManagementFormViewModel courseManagementFormViewModel;

            // When
            courseManagementFormViewModel = new();

            // Then
            Assert.IsNotNull(courseManagementFormViewModel);
        }
    }
}