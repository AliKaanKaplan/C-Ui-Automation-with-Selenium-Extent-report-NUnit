using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class CompletePageElements
    {
        private IWebDriver driver;

        public CompletePageElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By successOrderImage => By.CssSelector(".pony_express");
        public By backHomeButton => By.CssSelector("[data-test=back-to-products]");

    }
}
