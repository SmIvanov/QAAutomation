using OpenQA.Selenium;

namespace HomeworkPOM1.GoogleSearch
{
    public abstract class MainPage
    {
        private IWebDriver _driver;

        public MainPage(IWebDriver driver)
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