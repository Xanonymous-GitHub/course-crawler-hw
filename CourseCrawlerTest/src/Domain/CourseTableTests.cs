using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseCrawler;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCrawler.Tests
{
    [TestClass()]
    public class CourseTableTests
    {
        // CorrectlyCreateCourseTableFromSimpleList
        [TestMethod()]
        public void CorrectlyCreateCourseTableFromSimpleList()
        {
            // Given
            CourseTable courseTable;

            // When
            courseTable = new(string.Empty, new List<ICourse>());

            // Then
            Assert.IsNotNull(courseTable);
        }

        // CorrectlyCreateCourseTableFromBindingList
        [TestMethod()]
        public void CorrectlyCreateCourseTableFromBindingList()
        {
            // Given
            CourseTable courseTable;

            // When
            courseTable = new(string.Empty, new BindingList<ICourse>());

            // Then
            Assert.IsNotNull(courseTable);
        }

        // CorrectlyCreateCourseTableFromCourse
        [TestMethod()]
        public void CorrectlyCreateCourseTableFromCourse()
        {
            // Given
            CourseTable courseTable;
            Course testCourse = new(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, CourseType.NoType);

            // When

            courseTable = new(string.Empty, testCourse);

            // Then
            Assert.IsNotNull(courseTable);
        }
    }
}