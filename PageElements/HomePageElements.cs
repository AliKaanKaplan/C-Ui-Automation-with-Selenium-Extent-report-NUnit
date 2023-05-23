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
        public By productImage => By.CssSelector("div.inventory_item_img");
        public By productName => By.CssSelector(".inventory_item_name");
        public By productDesc => By.CssSelector(".inventory_item_desc");
        public By productPrice => By.CssSelector(".inventory_item_price");
        public By addCartButton => By.CssSelector(".pricebar > button");

    }
}
