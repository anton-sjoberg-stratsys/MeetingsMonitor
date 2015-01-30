using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MeetingsMonitor.App
{
    public class LoginToApplicationPage : BasePage
    {
        public LoginToApplicationPage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "headerContentLogo")]
        public IWebElement Header { get; set; }
        
        public override string Url
        {
            get { return "https://app.runyourmeeting.com/"; }
        }
    }
}