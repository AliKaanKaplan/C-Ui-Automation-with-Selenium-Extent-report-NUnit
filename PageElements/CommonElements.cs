using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class CommonElements
    {
        private IWebDriver driver;

        public CommonElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By cartButton => By.CssSelector(".shopping_cart_link");
        public By menuButton => By.CssSelector("#react-burger-menu-btn");

    }
}
