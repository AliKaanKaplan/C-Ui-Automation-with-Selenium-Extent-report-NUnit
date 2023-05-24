using AventStack.ExtentReports.Gherkin.Model;
using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class CompletePageSteps
    {
        private readonly IWebDriver _driver;
        private CompletePage _completePage;


        public CompletePageSteps(IWebDriver driver)
        {
            _driver = driver;
            _completePage = new CompletePage(driver);

        }

        [When(@"User clicks finish button")]
        public void clickFinishButton()
        {
            _completePage.clickFinishToButton();
        }

        [When(@"User clicks back home button")]
        public void clickBackHomeButton()
        {
            _completePage.clickBackToHomeButton();
        }
        [Then(@"User sees Successfull order sign")]
        public void successfullOrderSign()
        {
            _completePage.verifySuccessfulOrderSign();
        }
    }
}
