using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private LoginPageElements loginElements;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            loginElements = new LoginPageElements(driver);
        }

        public void EnterCredentialsAndSubmit(string username, string password)
        {
            SeleniumHelper.SendKeysToElement(_driver, loginElements.usernameInput, username);
            SeleniumHelper.SendKeysToElement(_driver, loginElements.passwordInput, password);
        }

        public void clickLoginButton()
        {
            SeleniumHelper.clickToElement(_driver, loginElements.loginButton);
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void userShouldSeeLoginPage()
        {
            SeleniumHelper.IsElementDisplayed(_driver, loginElements.loginButton);
        }
    }
}
