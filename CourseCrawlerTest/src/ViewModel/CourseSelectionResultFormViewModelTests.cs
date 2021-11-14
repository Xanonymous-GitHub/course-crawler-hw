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
    public class CourseSelectionResultFormViewModelTests
    {
        private CourseSelectionResultFormViewModel _courseSelectionResultFormViewModel;
        private SelectCourseFormViewModel _selectCourseFormViewModel;
        const int testDataSourceIndex = 1;
        const int testDisplayTabIndex = 5;

        [TestInitialize()]
        public void Init()
        {
            Pool.LoadCourses();
            _courseSelectionResultFormViewModel = new();
            _selectCourseFormViewModel = new();
        }

        // CorrectlyCreateCourseSelectionResultFormViewModel
        [TestMethod()]
        public void CorrectlyCreateCourseSelectionResultFormViewModel()
        {
            Assert.IsNotNull(_courseSelectionResultFormViewModel);
        }

        // CorrectlyGetSelectedCourseTableRows
        [TestMethod()]
        public void CorrectlyGetSelectedCourseTableRows()
        {
            _selectCourseFormViewModel.ChangeCourseCheckStatus(testDisplayTabIndex, true, testDataSourceIndex);
            _selectCourseFormViewModel.HandleSelectCourseSubmission();

            List<string[]> rows = _courseSelectionResultFormViewModel.GetSelectedCourseTableRows();
            Assert.IsNotNull(rows);
            Assert.AreEqual(1, rows.Count);
        }

        // CorrectlyUnselectCourse
        [TestMethod()]
        public void CorrectlyUnselectCourse()
        {
            _selectCourseFormViewModel.ChangeCourseCheckStatus(testDisplayTabIndex, true, testDataSourceIndex);
            _selectCourseFormViewModel.HandleSelectCourseSubmission();
            const int courseRowIndexToBeUnselected = 0;
            _courseSelectionResultFormViewModel.UnselectedCourse(courseRowIndexToBeUnselected);
            List<string[]> rows = _courseSelectionResultFormViewModel.GetSelectedCourseTableRows();
            Assert.IsNotNull(rows);
        }
    }
}