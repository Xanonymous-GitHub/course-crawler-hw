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
        // TIME LIMIT, CODE NAME is UGLY.
        [TestMethod()]
        public void CourseManagementFormTest()
        {
            // 1
            const string TestNameSelectCourseButton = "Manage Course";
            _robot.ClickButton(TestNameSelectCourseButton);
            _robot.SwitchTo(nameof(CourseManagementForm));
            _robot.ClickTabControl("課程管理");
            _robot.ClickByName("視窗程式設計");
            _robot.InputValueToTextBox("CourseRemarkTextBox", "Hi");
            _robot.AssertEnable("儲存", true);
            _robot.InputValueToTextBox("CourseRemarkTextBox", string.Empty);
            _robot.AssertEnable("儲存", false);

            // 2
            _robot.ClickTabControl("課程管理");
            _robot.ClickByName("視窗程式設計");
            _robot.ClickDataGridViewCellBy(6, "四");
            _robot.ClickDataGridViewCellBy(5, "四");
            _robot.AssertEnable("儲存", true);
            _robot.ClickDataGridViewCellBy(6, "四");
            _robot.AssertEnable("儲存", false);

            // 3
            _robot.SwitchTo(nameof(StartUpForm));
            _robot.ClickButton("Select Course");
            _robot.Sleep(5);
            _robot.SwitchTo(nameof(CourseManagementForm));
            _robot.InputValueToTextBox("CourseNumberTextBox", "270915");
            _robot.InputValueToTextBox("CourseNameTextBox", "物件導向分析與設計");
            _robot.InputValueToTextBox("CourseCreditTextBox", "2.0");
            _robot.ClickByName("時數(*)");
            _robot.ClickByName("2");
            _robot.ClickByName("班級(*)");
            _robot.ClickByName("電子三甲");
            _robot.ClickDataGridViewCellBy(2, "四");
            _robot.ClickDataGridViewCellBy(3, "四");
            _robot.ClickDataGridViewCellBy(6, "四");
            _robot.ClickDataGridViewCellBy(2, "一");
            _robot.ClickDataGridViewCellBy(2, "二");
            _robot.ClickByName("儲存");
        }

        // Cleanup
        [TestCleanup()]
        public void Cleanup()
        {
            _robot.CleanUp();
        }
    }
}