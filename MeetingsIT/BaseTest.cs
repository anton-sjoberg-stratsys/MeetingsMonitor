using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace MeetingsMonitor
{
    [TestFixture]
    public abstract class BaseTest<T> where T : BasePage
    {
        protected ChromeDriver _driver;
        protected T _page;

        protected abstract T CreatePage();

        [SetUp]
        public void SetUpBase()
        {
            StartDriver();
            _page = CreatePage();
            _page.GoToStart();
            PostStart();
            SetUp();
        }

        protected virtual void PostStart() { }

        protected virtual void SetUp() { }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        private void StartDriver()
        {
            _driver = new ChromeDriver(@"..\..\..\drivers", new ChromeOptions
            {
                LeaveBrowserRunning = false
            });
        }

        protected string GenerateName(string prefix)
        {
           return string.Format("{0} {1}", prefix, string.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
        }
    }
    
    [TestFixture]
    public abstract class AppBaseTest<T> : BaseTest<T> where T : BasePage
    {
        protected override void PostStart()
        {
            _page.UserName.SendKeys("erik.staring@stratsys.se");
            _page.Password.SendKeys("testa");

            _page.Form.Submit();
        }
    }
}