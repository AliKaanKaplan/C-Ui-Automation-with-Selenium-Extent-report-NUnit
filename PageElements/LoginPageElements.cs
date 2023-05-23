using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class LoginPageElements
    {
        private IWebDriver driver;

        public LoginPageElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By usernameInput => By.CssSelector("[data-test=username]");
        public By passwordInput => By.CssSelector("[data-test=password]");
        public By loginButton => By.CssSelector("[data-test=login-button]");

    }
}
