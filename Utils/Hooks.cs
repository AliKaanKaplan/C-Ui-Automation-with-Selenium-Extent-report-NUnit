using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using BoDi;
using MeDirectUiProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.Extensions.Configuration;

namespace MeDirectUiProject.Utils
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        private static ExtentReports _extent;
        private static ExtentTest _feature;
        private IWebDriver _driver;
        private ExtentTest _scenario;
        private ExtentTest _step;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        // Initialize ExtentReports before the test run
        [BeforeTestRun]
        public static void InitializeExtentReports()
        {
            _extent = ExtentHelper.GetExtent();
        }

        // Execute before each feature
        [BeforeFeature]
        public static void BeforeFeature()
        {
            var featureName = FeatureContext.Current.FeatureInfo.Title;
            _feature = _extent.CreateTest<Feature>(featureName);
        }

        // Execute before each scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            _scenario = _feature.CreateNode<Scenario>(scenarioName);

           _driver = CreateDriver();

            _container.RegisterInstanceAs(_driver);
        }

         public static IWebDriver CreateDriver()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("C:\\Users\\k.kaplan\\source\\repos\\UiAssignment\\appsettings.json")
                .Build();

            string browserName = configuration.GetSection("WebDriverConfig")["Browser"];

            IWebDriver driver = null;

            switch (browserName.ToLower())
            {
                case "firefox":
                    driver = CreateFirefoxDriver();
                    break;
                case "chrome":
                    driver = CreateChromeDriver();
                    break;
                default:
                    driver = CreateChromeDriver();
                    break;
            }

            driver.Manage().Window.Maximize();

            return driver;
        }

        private static IWebDriver CreateFirefoxDriver()
        {
            return new FirefoxDriver();
        }

        private static IWebDriver CreateChromeDriver()
        {
            return new ChromeDriver();
        }


        // Execute before each step
        [BeforeStep]
        public void BeforeStep()
        {
            var stepName = ScenarioStepContext.Current.StepInfo.Text;
            _step = _scenario.CreateNode<Given>(stepName);
        }

        // Execute after each step
        [AfterStep]
        public void AfterStep()
        {
            var stepName = ScenarioStepContext.Current.StepInfo.Text;

            if (ScenarioContext.Current.TestError == null)
            {
                _step.Pass("Passed");
            }
            else
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                var error = ScenarioContext.Current.TestError;

                var sanitizedStepName = ExtentHelper.SanitizeFileName(stepName);

                string errorMessage = $"{stepType} failed: {sanitizedStepName}\nError: {error}";
                var errorLabel = MarkupHelper.CreateCodeBlock(errorMessage);

                _step.Fail(errorLabel);

                string screenshotName = $"{sanitizedStepName}_Failure";
                string screenshotPath = ExtentHelper.TakeScreenshot(_driver, screenshotName);
                ExtentHelper.AddScreenshotToReport(_step, screenshotPath);
            }
        }

        // Execute after each scenario
        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        // Execute after the test run
        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentHelper.FlushReport();
        }
    }
}
