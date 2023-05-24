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
        public By finishButton => By.CssSelector("[data-test=finish]");
        public By totalPrice => By.CssSelector(".summary_total_label");
        public By productValue => By.CssSelector(".summary_subtotal_label");
        public By taxValue => By.CssSelector(".summary_tax_label");

    }
}
