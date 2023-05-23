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

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _homeElements = new HomePageElements(driver);
            _commonElements = new CommonElements(driver);
        }
        public void clickMenuAndClickSubMenu(string text)
        {
            SeleniumHelper.clickToElement(_driver, _commonElements.menuButton);
            SeleniumHelper.clickToElement(_driver, By.XPath("//nav[@class='bm-item-list']/a[text()='" + text + "']"));
        }
        public void selectFilter(string filterText)
        {
            SeleniumHelper.selectDropdownByText(_driver, _homeElements.filterDropdown, filterText);
        }
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

            if (filterType.Contains("A to Z")) {
                Assert.IsTrue(productNameList.SequenceEqual(sortedProductNameList));
            }

            if(filterType.Contains("Z to A"))
            {
                Array.Reverse(sortedProductNameList);
                Assert.IsTrue(productNameList.SequenceEqual(sortedProductNameList));
            }
        }

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





    }
}
