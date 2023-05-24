using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class CompletePage
    {
        private readonly IWebDriver _driver;
        private CompletePageElements _completePageElements;
        private OverviewPageElements _overviewPageElements;

        public CompletePage(IWebDriver driver)
        {
            _driver = driver;
            _completePageElements = new CompletePageElements(driver);
            _overviewPageElements = new OverviewPageElements(driver);
        }

        public void verifySuccessfulOrderSign()
        {
            SeleniumHelper.IsElementDisplayed(_driver, _completePageElements.successOrderImage);
        }
        public void clickBackToHomeButton()
        {
            SeleniumHelper.clickToElement(_driver, _completePageElements.backHomeButton);
        }
        public void clickFinishToButton()
        {
            SeleniumHelper.clickToElement(_driver, _overviewPageElements.finishButton);
        }
    }
}
