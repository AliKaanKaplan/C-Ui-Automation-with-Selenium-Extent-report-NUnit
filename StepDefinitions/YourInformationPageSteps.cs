using AventStack.ExtentReports.Gherkin.Model;
using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public class YourInformationPageSteps
    {
        private readonly IWebDriver _driver;
        private YourInformationPage _yourInformationPage;

        public YourInformationPageSteps(IWebDriver driver)
        {
            _driver = driver;
            _yourInformationPage = new YourInformationPage(driver);
        }

        [When(@"User fills (.*) (.*) and (.*) fields")]
        public void fillInformationForm(string userName, string lastName, string postalCode)
        {
            _yourInformationPage.fillRequiredForm(userName, lastName, postalCode);
        }

        [When(@"User clicks continue button")]
        public void clickContinueButton()
        {
            _yourInformationPage.clickToContinueButton();
        }

        [When(@"User clicks cancel button")]
        public void clickCancelButton()
        {
            _yourInformationPage.clickToCancelButton();
        }


    }
}
