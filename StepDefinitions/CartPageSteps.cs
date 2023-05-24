using AventStack.ExtentReports.Gherkin.Model;
using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class CartPageSteps
    {
        private readonly IWebDriver _driver;
        private CartPage _cartPage;

        public CartPageSteps(IWebDriver driver)
        {
            _driver = driver;
            _cartPage = new CartPage(driver);
        }

        [When(@"User clicks cart button")]
        public void navigateToCartPage(string text)
        {
            _cartPage.clickCartButton();
        }

        [Then(@"User sees added product")]
        public void verifyProduct()
        {
            _cartPage.verifyAddedProduct();
        }

        [Then(@"User sees quantity card")]
        public void verifyQuantityCard()
        {
            _cartPage.isDisplayQuantityCard();
        }

        [Then(@"User sees product name")]
        public void verifyProductName()
        {
            _cartPage.isDisplayProductName();
        }

        [Then(@"User sees product description")]
        public void verifyProductDescription()
        {
            _cartPage.isDisplayProductDescription();
        }

        [Then(@"User sees product price")]
        public void verifyProductPrice()
        {
            _cartPage.isDisplayProductPrice();
        }

        [When(@"User clicks remove button")]
        public void verifyRemove()
        {
            _cartPage.clickRemoveButton();
        }

        [When(@"User clicks continue shopping button")]
        public void continueShopping()
        {
            _cartPage.clickContinueShopping();
        }

        [When(@"User clicks checkout button")]
        public void goCheckout()
        {
            _cartPage.clickCheckoutButton();
        }
    }
}
