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
    public class CourseManagementFormTests
    {
        private readonly Robot _robot;

        [Obsolete]
        public CourseManagementFormTests()
        {
            _robot = new(Pool.GetExecutableDebugPath(), nameof(CourseManagementForm));
        }

        // SelectCourseFormTest
        [TestMethod()]
        public void CourseManagementFormTest()
        {
            const string TestNameSelectCourseButton = "Manage Course";
            _robot.ClickButton(TestNameSelectCourseButton);
        }

        // Cleanup
        [TestCleanup()]
        public void Cleanup()
        {
            _robot.CleanUp();
        }
    }
}