using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;
using System.Windows.Automation;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace CourseCrawler.Tests
{
    public class Robot
    {
        private WindowsDriver<WindowsElement> _driver;
        private Dictionary<string, string> _windowHandles;
        private string _root;
        private const string WIN_APP_DRIVER_URI = "http://127.0.0.1:4723";

        // constructor
        [Obsolete]
        public Robot(string targetAppPath, string root)
        {
            Initialize(targetAppPath, root);
        }

        // initialize
        [Obsolete]
        public void Initialize(string targetAppPath, string root)
        {
            _root = root;
            AppiumOptions options = new();
            options.AddAdditionalCapability("app", targetAppPath);
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            _driver = new(new Uri(WIN_APP_DRIVER_URI), options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _windowHandles = new()
            {
                { _root, _driver.CurrentWindowHandle }
            };
        }

        // clean up
        public void CleanUp()
        {
            SwitchTo(_root);
            _driver.CloseApp();
            _driver.Dispose();
        }

        // test
        public void SwitchTo(string formName)
        {
            if (_windowHandles.ContainsKey(formName))
            {
                _driver.SwitchTo().Window(_windowHandles[formName]);
            }
            else
            {
                foreach (string windowHandle in _driver.WindowHandles)
                {
                    _driver.SwitchTo().Window(windowHandle);
                    try
                    {
                        _driver.FindElementByAccessibilityId(formName);
                        _windowHandles.Add(formName, windowHandle);
                        return;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("ERR, " + e.ToString());
                    }
                }
            }
        }

        // test
        public void Sleep(double time)
        {
            Thread.Sleep(TimeSpan.FromSeconds(time));
        }

        // test
        public void ClickButton(string name)
        {
            _driver.FindElementByName(name).Click();
        }

        // test
        public void ClickTabControl(string name)
        {
            ReadOnlyCollection<WindowsElement> elements = _driver.FindElementsByName(name);
            foreach (WindowsElement element in elements)
            {
                if ("ControlType.TabItem" == element.TagName)
                    element.Click();
            }
        }

        // test
        public void CloseWindow()
        {
            SendKeys.SendWait("%{F4}");
        }

        // test
        public void CloseMessageBox()
        {
            _driver.FindElementByName("確定").Click();
        }

        // test
        public void ClickDataGridViewCellBy(int rowIndex, string columnName)
        {
            _driver.FindElementByName($"{columnName} 資料列 {rowIndex}").Click();
        }

        // test
        public void AssertEnable(string name, bool state)
        {
            WindowsElement element = _driver.FindElementByName(name);
            Assert.AreEqual(state, element.Enabled);
        }

        // test
        public void AssertText(string name, string text)
        {
            WindowsElement element = _driver.FindElementByAccessibilityId(name);
            Assert.AreEqual(text, element.Text);
        }

        // test
        public void AssertDataGridViewRowDataBy(string name, int rowIndex, string[] data)
        {
            WindowsElement dataGridView = _driver.FindElementByAccessibilityId(name);
            ReadOnlyCollection<AppiumWebElement> rowDatas = dataGridView.FindElementByName($"資料列 {rowIndex}").FindElementsByXPath("//*");

            for (int i = 1; i < rowDatas.Count; i++)
            {
                Assert.AreEqual(data[i - 1], rowDatas[i].Text.Replace("(null)", ""));
            }
        }

        // test
        public void AssertDataGridViewRowCountBy(string name, int rowCount)
        {
            WindowsElement dataGridView = _driver.FindElementByAccessibilityId(name);
            Point point = new(dataGridView.Location.X, dataGridView.Location.Y);
            AutomationElement element = AutomationElement.FromPoint(point);

            while (element != null && element.Current.LocalizedControlType.Contains("datagrid") == false)
            {
                element = TreeWalker.RawViewWalker.GetParent(element);
            }

            if (element != null && element.GetCurrentPattern(GridPattern.Pattern) is GridPattern gridPattern)
            {
                Assert.AreEqual(rowCount, gridPattern.Current.RowCount);
            }
        }

        // test
        public string[] GetDataGridViewRowDataStrings(string id, int rowIndex)
        {
            //var dataGridView = _driver.FindElementByAccessibilityId(id);
            ReadOnlyCollection<AppiumWebElement> rowDatas = _driver.FindElementByAccessibilityId(id).FindElementByName($"資料列 {rowIndex}").FindElementsByXPath("//*");
            List<string> stringsList = new();

            for (int i = 1; i < rowDatas.Count; i++)
            {
                stringsList.Add(rowDatas[i].Text.Replace("(null)", ""));
            }

            return stringsList.ToArray();
        }

        // test
        public string GetMessageBoxText()
        {
            WindowsElement element = _driver.FindElementByClassName("Static");
            return element.Text;
        }

        // test
        public void ClickByName(string name)
        {
            _driver.FindElementByName(name).Click();
        }

        // test
        public void InputValueToTextBox(string id, string text)
        {
            WindowsElement element = _driver.FindElementByAccessibilityId(id);
            element.Clear();
            element.SendKeys(text);
        }
    }
}
