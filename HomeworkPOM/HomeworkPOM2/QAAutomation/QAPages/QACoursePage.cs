using OpenQA.Selenium;

namespace HomeworkPOM2.QAAutomation
{
    public class QACoursePage : QABasePage
    {
        public QACoursePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement FoundResult => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));


        public string Result()
        {
            var foundResult = FoundResult.Text;
            return foundResult;
        }
    }
}