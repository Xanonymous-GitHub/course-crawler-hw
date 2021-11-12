using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseCrawler;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CourseCrawler.Tests
{
    [TestClass()]
    public class StartUpFormViewModelTests
    {
        private StartUpFormViewModel _startUpFormViewModel;

        [TestInitialize()]
        public void Init()
        {
            _startUpFormViewModel = new();
        }

        // CorrectlyCreateStartUpFormViewModel
        [TestMethod()]
        public void CorrectlyCreateStartUpFormViewModel()
        {
            Assert.IsNotNull(_startUpFormViewModel);
        }

        // ExpectAcceptToOpenSelectCourseFormChangeNotified
        [TestMethod()]
        public void ExpectAcceptToOpenSelectCourseFormChangeNotified()
        {
            Pool.ExpectNotified(_startUpFormViewModel, nameof(_startUpFormViewModel.AcceptToOpenSelectCourseForm), false);
        }

        // ExpectAcceptToOpenCourseManagementFormChangeNotified
        [TestMethod()]
        public void ExpectAcceptToOpenCourseManagementFormChangeNotified()
        {
            Pool.ExpectNotified(_startUpFormViewModel, nameof(_startUpFormViewModel.AcceptToOpenCourseManagementForm), false);
        }
    }
}