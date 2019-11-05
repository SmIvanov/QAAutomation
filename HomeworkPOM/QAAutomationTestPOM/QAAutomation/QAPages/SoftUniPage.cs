using OpenQA.Selenium;

namespace HomeworkPOM2.QAAutomation
{
    public class SoftUniPage : QABasePage
    {

        public SoftUniPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement NaviBarButton => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/a/span"));

        public IWebElement QAButton => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));

        public void Navigate()
        {
            Navigate("https://www.softuni.bg");
            NaviBarButton.Click();
            QAButton.Click();
        }

    }
}