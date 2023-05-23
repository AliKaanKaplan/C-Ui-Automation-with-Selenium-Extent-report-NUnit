using MeDirectUiProject.Helpers;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class CommonPage
    {
        private readonly IWebDriver _driver;

        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void IsTextDisplayed(string text)
        {
            SeleniumHelper.IsElementDisplayed(_driver, By.XPath("//*[text()='" + text + "']"));
        }
    }
}
