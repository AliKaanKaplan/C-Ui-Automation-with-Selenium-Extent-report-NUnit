using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class CheckoutCompletePageElements
    {
        private IWebDriver driver;

        public CheckoutCompletePageElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By successOrderImage => By.CssSelector(".pony_express");
        public By completeHeaderText => By.CssSelector(".complete-header");
        public By completeText => By.CssSelector(".complete-text");
        public By backHomeButton => By.CssSelector("[data-test=back-to-products]");

    }
}
