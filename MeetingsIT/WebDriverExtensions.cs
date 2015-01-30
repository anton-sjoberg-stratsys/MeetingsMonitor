using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MeetingsMonitor
{
    public static class WebDriverExtensions
    {
        public static void WaitFor(this IWebDriver driver, string className)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(drv => drv.FindElement(By.ClassName(className)));
        }
    }
}