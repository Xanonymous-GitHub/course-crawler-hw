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
    public class StartUpFormViewModelTests
    {
        // CorrectlyCreateStartUpFormViewModel
        [TestMethod()]
        public void CorrectlyCreateStartUpFormViewModel()
        {
            // Given
            StartUpFormViewModel startUpFormViewModel;

            // When
            startUpFormViewModel = new();

            // Then
            Assert.IsNotNull(startUpFormViewModel);
        }
    }
}