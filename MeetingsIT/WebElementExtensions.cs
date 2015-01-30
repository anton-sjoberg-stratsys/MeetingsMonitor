using OpenQA.Selenium;

namespace MeetingsMonitor
{
    public static class WebElementExtensions
    {
        public static string Value(this IWebElement webElement)
        {
            return webElement.GetAttribute("value");
        }
    }
}