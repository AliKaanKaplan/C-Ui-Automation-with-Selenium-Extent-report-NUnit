using AventStack.ExtentReports.Gherkin.Model;
using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class ProductDetailsPageSteps
    {
        private readonly ProductDetailsPage _productDetailsPage;
        private readonly CommonPage _commonPage;

        public ProductDetailsPageSteps(IWebDriver driver)
        {
            _productDetailsPage = new ProductDetailsPage(driver);
            _commonPage = new CommonPage(driver);
        }

        [When(@"User clicks back to products button")]
        public void clickBackToProductsButton()
        {
            _productDetailsPage.clickBackButton();
        }

        [When(@"User add to cart (.*) random product from Product Detail")]
        public void addToProductFromDetails(int productNumber)
        {
            _productDetailsPage.addProductFromDetailsPage(productNumber);
        }

        [When(@"User remove (.*) random product from Product Detail")]
        public void removeProductFromDetails(int productNumber)
        {
            _productDetailsPage.removeProductFromDetailsPage(productNumber);
        }

        [Then(@"User sees same product (.*) in (.*) random products")]
        public void verifyProductContent(string productType, int productNumber)
        {
            _productDetailsPage.verifyProductContent(productType, productNumber);
        }





    }
}
