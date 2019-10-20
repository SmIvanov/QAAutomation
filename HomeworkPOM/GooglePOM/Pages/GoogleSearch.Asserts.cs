using NUnit.Framework;

namespace HomeworkPOM1.GoogleSearch
{
    public partial class GoogleSearch
    {
        public void FoundResult(string foundResult)
        {
            Assert.AreEqual("Selenium - Web Browser Automation", foundResult);
        }
    }
}