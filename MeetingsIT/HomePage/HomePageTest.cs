using NUnit.Framework;

namespace MeetingsMonitor.HomePage
{
    public class HomePageTest : BaseTest<HomePage>
    {
        protected override HomePage CreatePage()
        {
            return new HomePage(_driver);
        }
        
        [Test]
        public void Signup()
        {
            _page.SignUpField.SendKeys("emaildoesnotexist@stratsys.se");
            _page.SignUpButton.Click();

            Assert.That(_page.RegisterEmail.Value(), Is.EqualTo("emaildoesnotexist@stratsys.se"));
        }
    }
}