using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MeetingsMonitor.HomePage
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "js-sign-up-field")]
        public IWebElement SignUpField { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-signup-btn")]
        public IWebElement SignUpButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-mail")]
        public IWebElement RegisterEmail { get; set; }

        public override string Url
        {
            get { return "https://www.runyourmeeting.com/"; }
        }
    }
}
