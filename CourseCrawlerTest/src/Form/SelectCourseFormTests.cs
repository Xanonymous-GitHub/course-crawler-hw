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
    public class SelectCourseFormTests
    {
        private readonly Robot _robot;

        [Obsolete]
        public SelectCourseFormTests()
        {
            _robot = new(Pool.GetExecutableDebugPath(), nameof(SelectCourseForm));
        }

        // SelectCourseFormTest
        // TIME LIMIT, CODE NAME is UGLY.
        [TestMethod()]
        public void SelectCourseFormTest()
        {
            const string TestNameSelectCourseButton = "Select Course";
            _robot.ClickButton(TestNameSelectCourseButton);
            _robot.Sleep(5);
            _robot.SwitchTo(nameof(SelectCourseForm));

            // 1
            _robot.ClickTabControl("資工三");
            _robot.ClickDataGridViewCellBy(5, "選");
            string[] first = _robot.GetDataGridViewRowDataStrings("CourseGridView", 5);
            string[] firstNext = _robot.GetDataGridViewRowDataStrings("CourseGridView", 6);
            _robot.ClickTabControl("電子三甲");
            _robot.ClickDataGridViewCellBy(3, "選");
            string[] second = _robot.GetDataGridViewRowDataStrings("CourseGridView", 3);
            string[] secondNext = _robot.GetDataGridViewRowDataStrings("CourseGridView", 4);
            _robot.ClickButton("確認送出");
            _robot.CloseMessageBox();
            _robot.AssertDataGridViewRowDataBy("CourseGridView", 3, firstNext);
            _robot.ClickTabControl("資工三");
            _robot.AssertDataGridViewRowDataBy("CourseGridView", 5, firstNext);
            _robot.ClickButton("查看選課結果");
            _robot.SwitchTo(nameof(CourseSelectionResultForm));
            _robot.AssertDataGridViewRowDataBy("CourseGridView", 0, first);
            _robot.AssertDataGridViewRowDataBy("CourseGridView", 1, second);
            _robot.ClickDataGridViewCellBy(1, "退");
            _robot.ClickDataGridViewCellBy(0, "退");
            _robot.SwitchTo(nameof(SelectCourseForm));
            _robot.AssertDataGridViewRowDataBy("CourseGridView", 5, first);
            _robot.ClickTabControl("電子三甲");
            _robot.AssertDataGridViewRowDataBy("CourseGridView", 3, second);

            // 2-1
            _robot.ClickTabControl("資工三");
            _robot.ClickDataGridViewCellBy(1, "選");
            _robot.ClickDataGridViewCellBy(0, "選");
            _robot.ClickTabControl("電子三甲");
            _robot.ClickDataGridViewCellBy(18, "選");
            _robot.ClickButton("確認送出");
            Assert.AreEqual("加選失敗\n衝堂:「291702-體育」、「290754-無線通信概論」", _robot.GetMessageBoxText());

            // 2-2
            _robot.ClickTabControl("資工三");
            _robot.ClickDataGridViewCellBy(1, "選");
            _robot.ClickDataGridViewCellBy(2, "選");
            _robot.ClickDataGridViewCellBy(3, "選");
            _robot.ClickButton("確認送出");
            Assert.AreEqual("加選失敗\n課程名稱相同:「291703-博雅選修課程」、「291704-博雅選修課程」", _robot.GetMessageBoxText());
        }

        // Cleanup
        // [TestCleanup()]
        public void Cleanup()
        {
            _robot.CleanUp();
        }
    }
}