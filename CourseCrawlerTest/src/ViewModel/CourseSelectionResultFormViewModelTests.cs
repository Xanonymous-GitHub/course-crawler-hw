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
    public class CourseSelectionResultFormViewModelTests
    {
        // CorrectlyCreateCourseSelectionResultFormViewModel
        [TestMethod()]
        public void CorrectlyCreateCourseSelectionResultFormViewModel()
        {
            // Given
            CourseSelectionResultFormViewModel courseSelectionResultFormViewModel;

            // When
            courseSelectionResultFormViewModel = new();

            // Then
            Assert.IsNotNull(courseSelectionResultFormViewModel);
        }
    }
}