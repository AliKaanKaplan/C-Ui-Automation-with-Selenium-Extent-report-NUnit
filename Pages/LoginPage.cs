using MyProject.Helpers;
using OpenQA.Selenium;


namespace MeDirectUiProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToHomePage()
        {
            // Ana sayfaya gitme işlemleri burada gerçekleştirilir
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void EnterCredentialsAndSubmit(string username, string password)
        {
            // Kullanıcı adı ve şifreyi girme işlemleri burada gerçekleştirilir
            var usernameInput = SeleniumHelper.FindElement(_driver, By.Id("user-name"));
            usernameInput.SendKeysToElement(username);

            var passwordInput = SeleniumHelper.FindElement(_driver, By.Id("password"));
            passwordInput.SendKeysToElement(password);

            var loginButton = SeleniumHelper.FindElement(_driver, By.Id("login-button"));
            loginButton.ClickElement();
        }

        public bool IsLoginInputDisplayed()
        {
            return SeleniumHelper.IsElementDisplayed(_driver, By.Id("user-name"));

        }

        public bool IsPasswordInputDisplayed()
        {
            return SeleniumHelper.IsElementDisplayed(_driver, By.Id("password"));

        }

        public bool IsLoginButtonDisplayed()
        {
            return SeleniumHelper.IsElementDisplayed(_driver, By.Id("login-button234234"));

        }
    }
}
