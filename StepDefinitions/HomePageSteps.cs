using FluentAssertions.Equivalency;
using MeDirectUiProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.Intrinsics.X86;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps
    {
        private IWebDriver driver;
        private readonly HomePage _homePage;

        public HomePageSteps(IWebDriver driver)
        {
            this.driver = driver;
            _homePage = new HomePage(driver);
        }



    }
}