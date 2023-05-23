using AventStack.ExtentReports.Gherkin.Model;
using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class LoginPageSteps
    {
        private readonly LoginPage _loginPage;
        private readonly CommonPage _commonPage;

        public LoginPageSteps(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
            _commonPage = new CommonPage(driver);
        }

        [Given(@"User is on the login page")]
        public void OpenLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When(@"User enters username (.*) and password (.*) on login page")]
        public void UserFillCredentials(string username, string password)
        {
            _loginPage.EnterCredentialsAndSubmit(username, password);
        }

        [When(@"User clicks login button")]
        public void userClickLoginButtons()
        {
            _loginPage.clickLoginButton();
        }

        [Then(@"User sees (.*) text on page")]
        public void userSeeText(string text)
        {
            _commonPage.IsTextDisplayed(text);
        }

        [Then(@"User see login page")]
        public void userSeeLoginPage()
        {
            _loginPage.userShouldSeeLoginPage();
        }
    }
}
