using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MeDirectUiProject.Helpers
{
    public static class SeleniumHelper
    {
        public static IWebElement WaitElementUntilVisible(this IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            try
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (WebDriverTimeoutException)
            {
                throw new NoSuchElementException($"Element with locator '{locator}' was not visible within {timeoutInSeconds} seconds.");
            }
        }

        public static IWebElement WaitElementUntilClickable(this IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            try
            {
                return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            }
            catch (WebDriverTimeoutException)
            {
                throw new NoSuchElementException($"Element with locator '{locator}' was not clickable within {timeoutInSeconds} seconds.");
            }
        }

        public static void SendKeysToElement(this IWebDriver driver, By locator, string text)
        {
            var element = WaitElementUntilClickable(driver, locator);
            try
            {
                element.SendKeys(text);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator)
        {
            var element = WaitElementUntilVisible(driver, locator);
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static void clickToElement(this IWebDriver driver, By locator)
        {
            var element = WaitElementUntilClickable(driver, locator);
            try
            {
                element.Click();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void selectDropdownByText(this IWebDriver driver, By locator,string text)
        {
            var element = WaitElementUntilClickable(driver, locator);
            SelectElement select = new SelectElement(element);
            try
            {
                select.SelectByText(text);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
