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
    public class CourseDayTimeTests
    {
        // CorrectlyCreateCourseDayTimeWithDefaultValues
        [TestMethod()]
        public void CorrectlyCreateCourseDayTimeWithDefaultValues()
        {
            // Given
            CourseDayTime courseDayTime;

            // When
            courseDayTime = new();

            // Then
            Assert.IsNotNull(courseDayTime);
            CollectionAssert.AreEqual(courseDayTime.WholeDayList, Enumerable.Repeat(false, 14).ToList());
        }

        // CorrectlyCreateCourseDayTimeWithDefinedValues
        [TestMethod()]
        public void CorrectlyCreateCourseDayTimeWithDefinedValues()
        {
            // Given
            CourseDayTime courseDayTime;
            bool[] testDayTimeStatus = new[] { false, true, false, true, false, true, false, true, false, true, false, true, false, true };

            // When
            courseDayTime = new(testDayTimeStatus);

            // Then
            Assert.IsNotNull(courseDayTime);
            CollectionAssert.AreEqual(courseDayTime.WholeDayList, testDayTimeStatus.ToList());
        }
    }
}