using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
                throw new NoSuchElementException($"Element with locator '{locator}' was not visible or displayed within {timeoutInSeconds} seconds.");
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
                throw new NoSuchElementException($"Element with locator '{locator}' was not clickable or displayed within {timeoutInSeconds} seconds.");
            }
        }

        public static void SendKeysToElement(this IWebDriver driver, By locator, string text)
        {
            var element = WaitElementUntilVisible(driver, locator);
            try
            {
                element.SendKeys(text);
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator)
        {
            var element = WaitElementUntilVisible(driver, locator);
            try
            {
                hoverToElement(driver, locator);
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool IsElementNotDisplayed(this IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                bool elementNotVisible = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
                return elementNotVisible;
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
                hoverToElement(driver, locator);
                element.Click();
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }
        }

        public static void clickToElement(this IWebDriver driver, IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }
        }

        public static void selectDropdownByText(this IWebDriver driver, By locator, string text)
        {
            var element = WaitElementUntilClickable(driver, locator);
            SelectElement select = new SelectElement(element);
            try
            {
                select.SelectByText(text);
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }
        }

        public static string getTextValue(this IWebDriver driver, By locator)
        {
            var element = WaitElementUntilClickable(driver, locator);
            try
            {
                hoverToElement(driver, locator);
                return element.Text;
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }
        }

        public static void hoverToElement(this IWebDriver driver, By locator)
        {
            Actions actions = new Actions(driver);

            var element = WaitElementUntilClickable(driver, locator);
            try
            {
                actions.MoveToElement(element).Perform();
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }
        }

        public static string getAttributeValueForList(this IWebDriver driver, string attributeName, IWebElement element)
        {

            try
            {
                string attributeValue = element.GetAttribute(attributeName);
                Assert.NotNull(attributeValue, "Öznitelik değeri boş");
                return attributeValue;
            }
            catch (Exception e)
            {
                throw new Exception("getTextValue metodu hatası.", e);
            }

        }

    }
}
