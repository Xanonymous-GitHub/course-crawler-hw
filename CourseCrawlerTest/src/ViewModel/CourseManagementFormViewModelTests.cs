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
    public class CourseManagementFormViewModelTests
    {
        private CourseManagementFormViewModel _courseManagementFormViewModel;
        private ICourse _testCourse;
        const int testDataSourceIndex = 0;
        const int testEditingIndex = 3;

        [TestInitialize()]
        public void Init()
        {
            Pool.LoadCourses();
            _courseManagementFormViewModel = new();
            _testCourse = new Course(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, CourseType.NoType);
        }

        // CorrectlyCreateCourseManagementFormViewModel
        [TestMethod()]
        public void CorrectlyCreateCourseManagementFormViewModel()
        {
            Assert.IsNotNull(_courseManagementFormViewModel);
        }

        // ExpectCurrentEditingContentChangeNotified
        [TestMethod()]
        public void ExpectCurrentEditingContentChangeNotified()
        {
            Pool.ExpectNotified(_courseManagementFormViewModel, nameof(_courseManagementFormViewModel.CurrentEditingContent), (testDataSourceIndex, _testCourse));
        }

        // ExpectCourseWeekTimeCheckStatesChangeNotified
        [TestMethod()]
        public void ExpectCourseWeekTimeCheckStatesChangeNotified()
        {
            List<List<bool>> testWeekTimeCHeckStates = new();
            testWeekTimeCHeckStates.Add(new());
            testWeekTimeCHeckStates.First().Add(true);

            Pool.ExpectNotified(_courseManagementFormViewModel, nameof(_courseManagementFormViewModel.CourseWeekTimeCheckStates), testWeekTimeCHeckStates);
        }

        // CorrectlyGenerateEditableFieldContens
        [TestMethod()]
        public void CorrectlyGenerateEditableFieldContens()
        {
            _courseManagementFormViewModel.GenerateEditableFieldContens(testEditingIndex);
            _courseManagementFormViewModel.GenerateEmptyFieldContens();
        }

        // CorrectlyUpdateCourse
        [TestMethod()]
        public void CorrectlyUpdateCourse()
        {
            const string testSerial = "0";
            const string testName = "name";
            const string testLevel = "0";
            const string testCredit = "0";
            const string testTeachers = "teachers";
            const string testType = "○";
            const string testTas = "tas";
            const string testLanguage = "";
            const string testRemark = "remark";
            const string testHour = "1";
            List<List<bool>> testTimes = Utils.InitializeArray(7, Utils.InitializeArray<bool>(14).ToList()).ToList();
            const bool testIsNewCourse = false;

            _courseManagementFormViewModel.GenerateEditableFieldContens(testEditingIndex);

            _courseManagementFormViewModel.UpdateCourse(testSerial, testName, testLevel, testCredit, testTeachers, testType, testTas, testLanguage, testRemark, testHour, testDataSourceIndex, testTimes, testIsNewCourse);
            
            _courseManagementFormViewModel.GenerateEditableFieldContens(testEditingIndex);
            _courseManagementFormViewModel.UpdateCourse(testSerial, testName, testLevel, testCredit, testTeachers, testType, testTas, testLanguage, testRemark, testHour, testDataSourceIndex + 1, testTimes, testIsNewCourse);
            
            _courseManagementFormViewModel.UpdateCourse(testSerial, testName, testLevel, testCredit, testTeachers, testType, testTas, testLanguage, testRemark, testHour, testDataSourceIndex, testTimes, !testIsNewCourse);
        }
    }
}