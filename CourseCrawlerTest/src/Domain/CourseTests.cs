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
        [TestMethod()]
        public void MakeSelectedTest()
        {
            // Given
            Course testCourse = new("", "", "", "", "", CourseType.NoType);

            // When
            testCourse.MakeSelected();

            // Then
            Assert.IsTrue(testCourse.IsSelected);
        }

        [TestMethod()]
        public void MakeUnselectedTest()
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