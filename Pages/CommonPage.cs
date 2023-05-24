using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class CommonPage
    {
        private readonly IWebDriver _driver;
        private ProductDetailsPageElements _productDetailsElements;
        private Random _random;

        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
            _productDetailsElements = new ProductDetailsPageElements(driver);
            _random = new Random();
        }

        // Check if the specified text is displayed on the page
        public void IsTextDisplayed(string text)
        {
            SeleniumHelper.IsElementDisplayed(_driver, By.XPath("//*[text()=\"" + text.Replace("\"", "\\\"") + "\"]"));
        }

        // Verify the current URL matches the expected URL
        public void verifyCurrentUrl(string expectedUrl)
        {
            string actualUrl = _driver.Url;

            Assert.AreEqual(expectedUrl, actualUrl, "URL verification error");
        }

        // Verify the product value is the same for a specified number of products
        public void productValueBeSame(int productNumber, string locator, string attributeName)
        {
            string homeValue;
            for (int i = 0; i < productNumber; i++)
            {
                int randomNo = _random.Next(1, productNumber);
                var element = _driver.FindElement(By.XPath("(//div[@class='inventory_item_img'])[" + randomNo + "]//" + locator));
                homeValue = SeleniumHelper.getAttributeValueForList(_driver, attributeName, element).Replace("$", "");

                SeleniumHelper.clickToElement(_driver, By.XPath("(//div[@class='inventory_item_img'])[" + randomNo + "]//img"));

                IsTextDisplayed(homeValue);

                SeleniumHelper.clickToElement(_driver, _productDetailsElements.backButton);
            }
        }
    }
}
