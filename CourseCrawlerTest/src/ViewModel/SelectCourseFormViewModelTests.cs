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
    public class SelectCourseFormViewModelTests
    {
        // CorrectlyCreateSelectCourseFormViewModel
        [TestMethod()]
        public void CorrectlyCreateSelectCourseFormViewModel()
        {
            // Given
            SelectCourseFormViewModel selectCourseFormViewModel;

            // When
            selectCourseFormViewModel = new();

            // Then
            Assert.IsNotNull(selectCourseFormViewModel);
        }
    }
}