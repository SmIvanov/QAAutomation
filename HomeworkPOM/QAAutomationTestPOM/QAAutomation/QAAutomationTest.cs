using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace HomeworkPOM2.QAAutomation
{
    [TestFixture]
    public class QAAutomationTest
    {
        private ChromeDriver _driver;
        private SoftUniPage _sUpage;
        private QACoursePage _qACoursePage;

        [SetUp]
        public void ClassInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();


            _sUpage = new SoftUniPage(_driver);
            _qACoursePage = new QACoursePage(_driver);
        }

        [Test]
        public void QAAutomationCourse()
        {
            _sUpage.Navigate();

            Assert.AreEqual(_qACoursePage.Result(), "QA Automation - септември 2019");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}