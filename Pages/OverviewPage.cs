using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class OverviewPage
    {
        private readonly IWebDriver _driver;
        private OverviewPageElements _overviewElements;

        public OverviewPage(IWebDriver driver)
        {
            _driver = driver;
            _overviewElements = new OverviewPageElements(driver);
        }
        public void calculateTotalPrice()
        {
            string productValue = SeleniumHelper.getTextValue(_driver, _overviewElements.productValue);
            decimal decproductValue = decimal.Parse(productValue.Substring(productValue.IndexOf("$") + 1));

            string taxValue = SeleniumHelper.getTextValue(_driver, _overviewElements.taxValue);
            decimal decTaxValue = decimal.Parse(taxValue.Substring(taxValue.IndexOf("$") + 1));


            string totalValue = SeleniumHelper.getTextValue(_driver, _overviewElements.totalPrice);
            decimal decTotalValue = decimal.Parse(totalValue.Substring(totalValue.IndexOf("$") + 1));

            Assert.AreEqual(decTotalValue, decproductValue + decTaxValue, "Total result calculated incorrectly.");
        }
    }
}
