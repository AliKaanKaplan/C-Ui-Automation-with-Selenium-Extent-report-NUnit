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
        public By logo => By.CssSelector(".app_logo");
        public By cartButton => By.CssSelector(".shopping_cart_link");
        public By menuButton => By.CssSelector("#react-burger-menu-btn");
        public By closeMenuButton => By.CssSelector("..bm-cross-button");   
        public By title => By.CssSelector(".title");
        public By qtyLabel => By.CssSelector(".cart_quantity_label");
        public By DescLabel => By.CssSelector(".cart_desc_label");

    }
}
