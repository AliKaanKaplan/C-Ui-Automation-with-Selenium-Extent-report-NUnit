using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class HomePageElements
    {

        private IWebDriver driver;

        public HomePageElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By filterDropdown => By.CssSelector(".product_sort_container");
        public By productImage => By.CssSelector("img.inventory_item_img");
        public By productName => By.CssSelector(".inventory_item_name");
        public By productPrice => By.CssSelector(".inventory_item_price");
        public By addCartButton => By.XPath("//button[text()='Add to cart']");
        public By productCountCart => By.CssSelector(".shopping_cart_badge");




    }
}
