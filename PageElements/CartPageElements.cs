using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class CartPageElements
    {
        private IWebDriver driver;

        public CartPageElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By continueShoppingButton => By.CssSelector("[data-test=continue-shopping]");
        public By quantityCard => By.CssSelector(".cart_quantity");
        public By productName => By.CssSelector(".inventory_item_name");
        public By productDetailsDesc => By.CssSelector(".inventory_details_desc");
        public By productPrice => By.CssSelector(".inventory_item_price");
        public By removeButton => By.CssSelector(".item_pricebar > button");
        public By checkoutButton => By.CssSelector("[data-test=checkout]");
    }
}
