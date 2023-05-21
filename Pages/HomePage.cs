using MyProject.Helpers;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }


    }
}
