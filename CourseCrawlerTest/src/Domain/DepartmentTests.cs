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
    public class DepartmentTests
    {
        [TestMethod()]
        public void CorrectlyCreateDepartmentFromDictionary()
        {
            // Given
            Department department;

            // When
            department = new(string.Empty, new Dictionary<string, ICourseTable>());

            // Then
            Assert.IsNotNull(department);
            Assert.IsNotNull(department.CourseTables);
        }

        [TestMethod()]
        public void CorrectlyCreateDepartmentFromSimpleCourseTable()
        {
            // Given
            Department department;

            const string testTableName = "test";
            CourseTable courseTable = new(testTableName, new List<ICourse>());
            Dictionary<string, ICourseTable> courseTables = new();
            courseTables.Add(testTableName, courseTable);

            // When
            department = new(string.Empty, courseTable);

            // Then
            Assert.IsNotNull(department);
            Assert.AreEqual(department.CourseTables[testTableName].Name, courseTables[testTableName].Name);
        }
    }
}