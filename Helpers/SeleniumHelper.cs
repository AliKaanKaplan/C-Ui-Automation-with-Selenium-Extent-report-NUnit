using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyProject.Helpers
{
    public static class SeleniumHelper
    {
        public static IWebElement FindElement(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(driver => driver.FindElement(by));
        }

        public static void ClickElement(this IWebElement element)
        {
            element.Click();
        }

        public static void SendKeysToElement(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator)
        {
            try
            {
                var element = driver.FindElement(locator);
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
