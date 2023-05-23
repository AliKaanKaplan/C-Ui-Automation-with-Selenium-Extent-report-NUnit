using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps
    {
        private IWebDriver driver;
        private readonly HomePage _homePage;

        public HomePageSteps(IWebDriver driver)
        {
            this.driver = driver;
            _homePage = new HomePage(driver);
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
            if(filterText == "Name (A to Z)" || filterText == "Name (Z to A)")
                _homePage.verifySortingName(filterText);
            else if(filterText == "Price (low to high)" || filterText == "Price (high to low)")
                _homePage.verifySortingPrice(filterText);
        }




    }
}