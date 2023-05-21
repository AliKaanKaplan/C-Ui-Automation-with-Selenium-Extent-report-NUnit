using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using MeDirectUiProject.Helpers;
using MeDirectUiProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class LoginPageSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;
        private ExtentTest _test;

        public LoginPageSteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(driver);
        }

        [Given(@"User is on the homepage")]
        public void GivenUserIsOnTheHomepage()
        {
            // Gerekirse test nesnesini güncelle ve başarılı sonucu raporla
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            _loginPage.NavigateToHomePage();
            // Gerekirse test nesnesini güncelle ve başarılı sonucu raporla
        }

        [Then(@"User should see username textbox")]
        public void ThenUserShouldSeeUsernameTextbox()
        {
            Assert.IsTrue(_loginPage.IsLoginInputDisplayed());
            // Gerekirse test nesnesini güncelle ve başarılı sonucu raporla
        }

        [Then(@"User should see password textbox")]
        public void ThenUserShouldSeePasswordTextbox()
        {
            Assert.IsTrue(_loginPage.IsPasswordInputDisplayed());
            // Gerekirse test nesnesini güncelle ve başarılı sonucu raporla
        }

        [Then(@"User should see login button")]
        public void ThenUserShouldSeeLoginButton()
        {
            Assert.IsTrue(_loginPage.IsLoginButtonDisplayed(), "User should see login button");

            // Gerekirse test nesnesini güncelle ve başarılı sonucu raporla
        }

        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string username, string password)
        {
            _loginPage.EnterCredentialsAndSubmit(username, password);
            Thread.Sleep(5000);
            // Gerekirse test nesnesini güncelle ve başarılı sonucu raporla
        }
    }
}
