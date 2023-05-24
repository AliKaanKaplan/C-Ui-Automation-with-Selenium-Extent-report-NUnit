using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private HomePageElements _homeElements;
        private CommonElements _commonElements;
        private Random _random;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _homeElements = new HomePageElements(driver);
            _commonElements = new CommonElements(driver);
            _random = new Random();
        }

        // Click on the menu button and then click on a sub-menu item based on the provided text
        public void clickMenuAndClickSubMenu(string text)
        {
            SeleniumHelper.clickToElement(_driver, _commonElements.menuButton);
            SeleniumHelper.clickToElement(_driver, By.XPath("//nav[@class='bm-item-list']/a[text()='" + text + "']"));
        }

        // Select a filter from the dropdown based on the provided filterText
        public void selectFilter(string filterText)
        {
            SeleniumHelper.selectDropdownByText(_driver, _homeElements.filterDropdown, filterText);
        }

        // Verify the sorting of product names based on the filter type
        public void verifySortingName(string filterType)
        {
            IList<IWebElement> elements = _driver.FindElements(_homeElements.productName);
            string[] productNameList = new string[elements.Count];
            string[] sortedProductNameList = new string[elements.Count];

            for (int i = 0; i < elements.Count; i++)
            {
                productNameList[i] = elements[i].Text;
            }

            Array.Copy(productNameList, sortedProductNameList, productNameList.Length);

            Array.Sort(sortedProductNameList);

            if (filterType.Contains("A to Z"))
            {
                Assert.IsTrue(productNameList.SequenceEqual(sortedProductNameList));
            }

            if (filterType.Contains("Z to A"))
            {
                Array.Reverse(sortedProductNameList);
                Assert.IsTrue(productNameList.SequenceEqual(sortedProductNameList));
            }
        }

        // Verify the sorting of product prices based on the filter type
        public void verifySortingPrice(string filterType)
        {
            IList<IWebElement> elements = _driver.FindElements(_homeElements.productPrice);
            string[] productPriceList = new string[elements.Count];

            decimal[] convertedPriceList = new decimal[productPriceList.Length];
            decimal[] sortedConvertedPriceList = new decimal[productPriceList.Length];

            for (int i = 0; i < elements.Count; i++)
            {
                productPriceList[i] = elements[i].Text.Replace("$", "");
                convertedPriceList[i] = decimal.Parse(productPriceList[i]);
            }

            Array.Copy(convertedPriceList, sortedConvertedPriceList, convertedPriceList.Length);

            Array.Sort(sortedConvertedPriceList);

            if (filterType.Contains("Price (low to high)"))
            {
                Assert.IsTrue(convertedPriceList.SequenceEqual(sortedConvertedPriceList));
            }

            if (filterType.Contains("Price (high to low)"))
            {
                Array.Reverse(sortedConvertedPriceList);
                Assert.IsTrue(convertedPriceList.SequenceEqual(sortedConvertedPriceList));
            }
        }

        // Add a specified number of products to the cart
        public void addProductCart(int productNumber)
        {
            for (int i = 0; i < productNumber; i++)
            {
                IList<IWebElement> elements = _driver.FindElements(_homeElements.addCartButton);
                SeleniumHelper.clickToElement(_driver, elements[_random.Next(0, elements.Count)]);
            }
        }

        // Verify the product count in the cart matches the provided productNumber
        public void verifyProductCount(string productNumber)
        {
            Assert.IsTrue(SeleniumHelper.IsElementDisplayed(_driver, _homeElements.productCountCart));
            string productCount = SeleniumHelper.getTextValue(_driver, _homeElements.productCountCart);
            Assert.AreEqual(productNumber, productCount, "Product number is incorrect.");
        }

        // Click on a random product image
        public void clickRandomProductImage()
        {
            IList<IWebElement> elements = _driver.FindElements(_homeElements.productImage);
            SeleniumHelper.clickToElement(_driver, elements[_random.Next(0, elements.Count)]);
        }

        // Verify that the product count in the cart is reset
        public void verifyResetProductCount()
        {
            SeleniumHelper.IsElementNotDisplayed(_driver, _homeElements.productCountCart);
        }

        // Verify that all image links are unique
        public void verifyImageLinks()
        {
            IList<IWebElement> elements = _driver.FindElements(_homeElements.productImage);
            string[] imageLinks = new string[elements.Count];

            for (int i = 0; i < elements.Count; i++)
            {
                string imgLink = SeleniumHelper.getAttributeValueForList(_driver, "src", elements[i]);
                imageLinks[i] = imgLink;
            }

            Assert.IsTrue(imageLinks.Distinct().Count() == imageLinks.Length, "All images are no different.");
        }

        // Click on the cart button
        public void clickToCartButton()
        {
            SeleniumHelper.clickToElement(_driver, _commonElements.cartButton);
        }
    }
}
