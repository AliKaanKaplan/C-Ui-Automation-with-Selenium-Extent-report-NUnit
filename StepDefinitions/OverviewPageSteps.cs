using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public class OverviewPageSteps
    {
        private readonly OverviewPage _overviewPage;

        public OverviewPageSteps(IWebDriver driver)
        {
            _overviewPage = new OverviewPage(driver);

        }

        [Then(@"User sees correct total price")]
        public void verifyTotalPrice()
        {
            _overviewPage.calculateTotalPrice();
        }

    }
}
