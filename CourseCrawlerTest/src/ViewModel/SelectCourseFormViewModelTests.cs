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
    public class SelectCourseFormViewModelTests
    {
        private SelectCourseFormViewModel _selectCourseFormViewModel;
        const int testDataSourceIndex = 0;
        const int testDisplayTabIndex = 0;

        [TestInitialize()]
        public void Init()
        {
            _selectCourseFormViewModel = new();
        }

        // CorrectlyCreateSelectCourseFormViewModel
        [TestMethod()]
        public void CorrectlyCreateSelectCourseFormViewModel()
        {
            Assert.IsNotNull(_selectCourseFormViewModel);
        }

        // CorrectlyGetCourseTableRows
        [TestMethod()]
        public void CorrectlyGetCourseTableRows()
        {
            List<string[]> rows = _selectCourseFormViewModel.GetCourseTableRows(testDataSourceIndex);
            Assert.IsNotNull(rows);
        }

        [TestMethod()]
        // CorrectlyChangeCourseCheckStatus
        public void CorrectlyCheckACourse()
        {
            _selectCourseFormViewModel.ChangeCourseCheckStatus(testDisplayTabIndex, true, testDataSourceIndex);
            Assert.IsTrue(_selectCourseFormViewModel.IsAnyCourseChecked());

            _selectCourseFormViewModel.MakeAllUnCheck();
            Assert.IsFalse(_selectCourseFormViewModel.IsAnyCourseChecked());
        }

        // SubmmitCourseSelectionRequestWithoutConflicts
        [TestMethod()]
        public void SubmmitCourseSelectionRequestWithoutConflicts()
        {
            _selectCourseFormViewModel.MakeAllUnCheck();
            _selectCourseFormViewModel.ChangeCourseCheckStatus(testDisplayTabIndex, true, testDataSourceIndex);
            Assert.IsFalse(_selectCourseFormViewModel.IsAnyCourseSelected());
            Result submissionResult = _selectCourseFormViewModel.HandleSelectCourseSubmission();
            Assert.IsTrue(submissionResult.Success);
        }

        // SubmmitCourseSelectionRequestWithConflicts
        [TestMethod()]
        public void SubmmitCourseSelectionRequestWithConflicts()
        {
            _selectCourseFormViewModel.MakeAllUnCheck();

            int courseAmountInTable = _selectCourseFormViewModel.GetCourseTableRows(testDataSourceIndex).Count;

            for (int i = 0; i < courseAmountInTable; i++)
            {
                _selectCourseFormViewModel.ChangeCourseCheckStatus(i, true, testDataSourceIndex);
            }
            
            Result submissionResult = _selectCourseFormViewModel.HandleSelectCourseSubmission();
            Assert.IsTrue(submissionResult.Failure);
        }
    }
}