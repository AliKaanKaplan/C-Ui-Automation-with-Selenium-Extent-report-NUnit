using OpenQA.Selenium;

namespace MeDirectUiProject.PageElements
{
    public class YourInformationPageElements
    {
        private IWebDriver driver;

        public YourInformationPageElements(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By cancelButton => By.CssSelector("[data-test=cancel]");
        public By continueButton => By.CssSelector("[data-test=continue]");
        public By firstnameTextbox => By.CssSelector("[data-test=firstName]");
        public By lastnameTextbox => By.CssSelector("[data-test=lastName]");
        public By postalCodeTextbox => By.CssSelector("[data-test=postalCode]");
    }
}
