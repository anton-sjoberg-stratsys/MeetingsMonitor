using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MeetingsMonitor
{
    public abstract class BasePage
    {
        [FindsBy(How = How.TagName, Using = "body")]
        public IWebElement Body { get; set; }
        
        [FindsBy(How = How.Id, Using = "txtUserName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.TagName, Using = "form")]
        public IWebElement Form { get; set; }

        protected readonly IWebDriver _driver;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }

        public void GoToStart()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public abstract string Url { get; }
    }
}