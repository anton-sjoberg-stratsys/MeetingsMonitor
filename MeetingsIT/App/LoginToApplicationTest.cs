using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace MeetingsMonitor.App
{
    public class LoginToApplicationTest : AppBaseTest<LoginToApplicationPage>
    {
        protected override LoginToApplicationPage CreatePage()
        {
            return new LoginToApplicationPage(_driver);
        }
        
        [Test]
        public void LoginToApplication()
        {
            Assert.That(_page.Header.Text, Is.EqualTo("RunYourMeeting"));
        }
    }
}