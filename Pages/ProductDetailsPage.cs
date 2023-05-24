using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class ProductDetailsPage
    {
        private readonly IWebDriver _driver;
        private ProductDetailsPageElements _productDetailsElements;
        private HomePageElements _homeElements;
        private CommonElements _commonElements;
        private CommonPage _commonPage;
        private Random _random;

        public ProductDetailsPage(IWebDriver driver)
        {
            _driver = driver;
            _productDetailsElements = new ProductDetailsPageElements(driver);
            _commonElements = new CommonElements(driver);
            _homeElements = new HomePageElements(driver);
            _random = new Random();
            _commonPage = new CommonPage(driver);
        }

        public void clickBackButton()
        {
            SeleniumHelper.clickToElement(_driver, _productDetailsElements.backButton);
        }

        public void addProductFromDetailsPage(int productNumber)
        {
            for (int i = 0; i < productNumber; i++)
            {
                IList<IWebElement> elements = _driver.FindElements(By.XPath("//button[text()='Add to cart']/../../..//img"));
                SeleniumHelper.clickToElement(_driver, elements[_random.Next(0, elements.Count)]);

                SeleniumHelper.clickToElement(_driver, _productDetailsElements.productDetailsAddButton);

                SeleniumHelper.clickToElement(_driver, _productDetailsElements.backButton);
            }
        }

        public void removeProductFromDetailsPage(int productNumber)
        {
            for (int i = 0; i < productNumber; i++)
            {
                IList<IWebElement> elements = _driver.FindElements(By.XPath("//button[text()='Remove']/../../..//img"));
                SeleniumHelper.clickToElement(_driver, elements[_random.Next(0, elements.Count)]);

                SeleniumHelper.clickToElement(_driver, _productDetailsElements.productDetailsAddButton);

                SeleniumHelper.clickToElement(_driver, _productDetailsElements.backButton);
            }
        }

        public void verifyProductContent(string productType, int productNumber)
        {
            switch (productType)
            {
                case "name":
                    _commonPage.productValueBeSame(productNumber, "..//div[@class='inventory_item_name']", "textContent");
                    break;
                case "description":
                    _commonPage.productValueBeSame(productNumber, "..//div[@class='inventory_item_desc']", "textContent");
                    break;
                case "price":
                    _commonPage.productValueBeSame(productNumber, "..//div[@class='inventory_item_price']", "textContent");
                    break;
                case "image":
                    productImageBeSame(productNumber);
                    break;
                default:
                    Console.WriteLine("Invalid productType value!");
                    break;
            }
        }


        public void productImageBeSame(int productNumber)
        {
            string homeValue, detailValue;
            for (int i = 0; i < productNumber; i++)
            {
                int randomNo = _random.Next(1, productNumber + 1);
                var homeElement = _driver.FindElement(By.XPath("(//img[@class='inventory_item_img' or @class='inventory_details_container'])[" + randomNo + "]"));

                homeValue = SeleniumHelper.getAttributeValueForList(_driver, "src", homeElement);

                homeElement.Click();

                var detailElement = _driver.FindElement(_productDetailsElements.productImage);
                detailValue = SeleniumHelper.getAttributeValueForList(_driver, "src", detailElement);

                Assert.AreEqual(homeValue, detailValue, "The product image on the main page and the photo in the product detail should be the same.");

                SeleniumHelper.clickToElement(_driver, _productDetailsElements.backButton);
            }
        }

    }
}
