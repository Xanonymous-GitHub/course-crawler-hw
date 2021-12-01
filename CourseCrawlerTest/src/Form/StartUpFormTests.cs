using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCrawler.Tests
{
    [TestClass()]
    public class StartUpFormTests
    {
        private readonly Robot _robot;

        [Obsolete]
        public StartUpFormTests() 
        {
            _robot = new(Pool.GetExecutableDebugPath(), nameof(StartUpForm));
        }

        // StartUpFormTest
        [TestMethod()]
        public void StartUpFormTest()
        {
            const string TestNameSelectCourseButton = "Select Course";
            _robot.ClickButton(TestNameSelectCourseButton);
            _robot.AssertEnable(TestNameSelectCourseButton, false);

            const string TestNameManageCourseButton = "Manage Course";
            _robot.ClickButton(TestNameManageCourseButton);
            _robot.AssertEnable(TestNameManageCourseButton, false);
        }

        // Cleanup
        [TestCleanup()]
        public void Cleanup() 
        {
            _robot.CleanUp();
        }
    }
}