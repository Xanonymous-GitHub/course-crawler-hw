using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace CourseCrawler.Tests
{
    public static class Pool
    {
        // ExpectNotified
        public static void ExpectNotified<T>(INotifyPropertyChanged observable, string propertyName, T newValue)
        {
            Assert.IsNotNull(observable);

            bool notified = false;
            observable.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                notified = e.PropertyName == propertyName;
            };

            System.Type observableRunTimeType = observable.GetType();
            Assert.IsNotNull(observableRunTimeType);
            Assert.IsInstanceOfType(observable, observableRunTimeType);

            PropertyInfo propertyInfo = observableRunTimeType.GetProperty(propertyName);
            Assert.IsNotNull(propertyInfo);
            Assert.AreNotEqual(newValue, propertyInfo.GetValue(observable, null));

            propertyInfo.SetValue(observable, newValue, null);
            Assert.IsTrue(notified);
        }

        // LoadCourses
        public static void LoadCourses()
        {
            for (int dataSourceIndex = 0; dataSourceIndex < SupportedDataSourceInfo.Amount; dataSourceIndex++)
            {
                GetCourseTableUseCase getCourseTableUseCase = new(dataSourceIndex);
                getCourseTableUseCase.Do();
            }
        }
    }
}
