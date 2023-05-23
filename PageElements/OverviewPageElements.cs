using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class OverviewPageElements
    {
        private IWebDriver driver;

        public OverviewPageElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By continueShoppingButton => By.CssSelector("[data-test=continue-shopping]");
        public By cancelButton => By.CssSelector("[data-test=cancel]");
        public By finishButton => By.CssSelector("[data-test=finish]");
        public By quantityCard => By.CssSelector(".cart_quantity");
        public By productName => By.CssSelector(".inventory_item_name");
        public By productDetailsDesc => By.CssSelector(".inventory_item_desc");
        public By productPrice => By.CssSelector(".inventory_item_price");
        public By summaryLabel => By.CssSelector(".summary_info > .summary_info_label");
        public By paymentLabelValue => By.XPath("//div[@class='summary_info']//div[@class='summary_value_label'][1]");
        public By ShippingLabelValue => By.XPath("//div[@class='summary_info']//div[@class='summary_value_label'][2]");
        public By totalProductValue => By.CssSelector(".summary_subtotal_label");
        public By taxValue => By.CssSelector(".summary_tax_label");

    }
}
