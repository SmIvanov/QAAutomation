using OpenQA.Selenium;

namespace HomeworkPOM1.GoogleSearch
{
    public class GoogleSearchPage : MainPage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement GoogleSearchBar => Driver.FindElement(By.Name("q"));


    }
}