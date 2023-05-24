using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class ProductDetailsPageElements
    {
        private IWebDriver driver;

        public ProductDetailsPageElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By backButton => By.CssSelector("#back-to-products");
        public By productImage => By.CssSelector("img.inventory_details_img");
        public By productDetailsAddButton => By.CssSelector(".inventory_details_desc_container > button");

    }
}
