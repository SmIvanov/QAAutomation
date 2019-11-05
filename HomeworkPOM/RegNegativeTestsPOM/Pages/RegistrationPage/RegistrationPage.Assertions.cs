using NUnit.Framework;

namespace HomeworkPOM.Pages
{
    public partial class RegistrationPage
    {

        public void AssertErrorMessage(string expected)
        {
            Assert.AreEqual(expected, ErrorMessage.Text);
        }

        public void AssertErrorMessages(string expected)
        {
            Assert.AreEqual(expected, ErrorMessages.Text);
        }
    }
}
