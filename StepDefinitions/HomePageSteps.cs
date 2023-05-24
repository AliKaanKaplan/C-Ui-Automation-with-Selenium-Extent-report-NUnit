using AventStack.ExtentReports.Gherkin.Model;
using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps
    {
        private IWebDriver driver;
        private readonly HomePage _homePage;
        private readonly CommonPage _commonPage;

        public HomePageSteps(IWebDriver driver)
        {
            this.driver = driver;
            _homePage = new HomePage(driver);
            _commonPage = new CommonPage(driver);
        }

        [When(@"User clicks menu button and clicks (.*) submenu")]
        public void userClickMenuButtons(string text)
        {
            _homePage.clickMenuAndClickSubMenu(text);
        }

        [When(@"User select filter (.*)")]
        public void UserSelectFilterOption(string filterText)
        {
            _homePage.selectFilter(filterText);
        }

        [Then(@"The user sees them correctly ordered from (.*)")]
        public void UserSeesCorrectlyOrdered(string filterText)
        {
            if (filterText == "Name (A to Z)" || filterText == "Name (Z to A)")
                _homePage.verifySortingName(filterText);
            else if (filterText == "Price (low to high)" || filterText == "Price (high to low)")
                _homePage.verifySortingPrice(filterText);
        }

        [When(@"User add to cart (.*) random product")]
        public void addRandomProduct(int productNumber)
        {
            _homePage.addProductCart(productNumber);
        }

        [Then(@"User sees the (.*) of products")]
        public void verifyNumberProduct(string productNumber)
        {
            _homePage.verifyProductCount(productNumber);
        }


        [When(@"User clicks random product image")]
        public void clickRandomProduct()
        {
            _homePage.clickRandomProductImage();
        }

        [Then(@"User sees about page")]
        public void verifyNavigateAboutPage()
        {
            _commonPage.verifyCurrentUrl("https://saucelabs.com/");
        }

        [Then(@"User sees that the number of items in the basket has been reset.")]
        public void resetProductCount()
        {
            _homePage.verifyResetProductCount();
        }

        [Then(@"User sees different photos of all products")]
        public void differentPhotos()
        {
            _homePage.verifyImageLinks();
        }

        [When(@"User clicks cart button")]
        public void clickCartButton()
        {
            _homePage.clickToCartButton();
        }









    }
}