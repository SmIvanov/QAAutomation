using OpenQA.Selenium;

namespace HomeworkPOM.Extensions
{
    using OpenQA.Selenium;
    public static class ElementExtensions
    {
        public static void Type(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
