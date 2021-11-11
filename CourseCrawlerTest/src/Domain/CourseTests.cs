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
    public class CourseTests
    {
        // CorrectlyMakeSelected
        [TestMethod()]
        public void CorrectlyMakeSelected()
        {
            // Given
            Course testCourse = new("", "", "", "", "", CourseType.NoType);

            // When
            testCourse.MakeSelected();

            // Then
            Assert.IsTrue(testCourse.IsSelected);
        }

        // MakeUnselectedTest
        [TestMethod()]
        public void CorrectlyMakeUnselected()
        {
            // Given
            Course testCourse = new("", "", "", "", "", CourseType.NoType);

            // When
            testCourse.MakeUnselected();

            // Then
            Assert.IsFalse(testCourse.IsSelected);
        }
    }
}