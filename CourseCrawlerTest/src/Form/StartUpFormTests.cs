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
            _robot = new(Pool.GetExecutableDebugPath(Pool.ResloveExecutorPath()), nameof(StartUpForm));
        }

        [TestMethod()]
        public void StartUpFormTest()
        {
            Assert.IsTrue(true);
        }
    }
}