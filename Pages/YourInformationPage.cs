using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class YourInformationPage
    {
        private readonly IWebDriver _driver;
        private YourInformationPageElements _YourInfoElements;


        public YourInformationPage(IWebDriver driver)
        {
            _driver = driver;
            _YourInfoElements = new YourInformationPageElements(driver);
        }

        public void fillRequiredForm(string userName, string lastName, string postalCode)
        {

            SeleniumHelper.SendKeysToElement(_driver, _YourInfoElements.firstnameTextbox, userName);
            SeleniumHelper.SendKeysToElement(_driver, _YourInfoElements.lastnameTextbox, lastName);
            SeleniumHelper.SendKeysToElement(_driver, _YourInfoElements.postalCodeTextbox, postalCode);
        }

        public void clickToContinueButton()
        {
            SeleniumHelper.clickToElement(_driver, _YourInfoElements.continueButton);
        }

        public void clickToCancelButton()
        {
            SeleniumHelper.clickToElement(_driver, _YourInfoElements.cancelButton);
        }


    }
}
