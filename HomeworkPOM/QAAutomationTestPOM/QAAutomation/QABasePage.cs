using OpenQA.Selenium;

namespace HomeworkPOM2.QAAutomation
{
    public abstract class QABasePage
    {
        private IWebDriver _driver;

        public QABasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public virtual void Navigate(string url)
        {
            Driver.Url = url;
        }

    }
}