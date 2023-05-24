using MeDirectUiProject.Pages;
using OpenQA.Selenium;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class CommonPageSteps
    {
        private readonly IWebDriver _driver;
        private readonly CommonPage _commonPage;

        public CommonPageSteps(IWebDriver driver)
        {
            _driver = driver;
            _commonPage = new CommonPage(driver);
        }

        [Then(@"User sees ""(.*)"" text on page")]
        public void userSeeText(string text)
        {
            _commonPage.IsTextDisplayed(text);
        }
    }
}
