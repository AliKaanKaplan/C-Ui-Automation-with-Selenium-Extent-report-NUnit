using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using BoDi;
using MeDirectUiProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        [BeforeTestRun]
        public static void InitializeExtentReports()
        {
            _extent = ExtentHelper.GetExtent();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            var featureName = FeatureContext.Current.FeatureInfo.Title;
            _feature = _extent.CreateTest<Feature>(featureName);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            _scenario = _feature.CreateNode<Scenario>(scenarioName);

            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs(_driver);

            ExtentHelper.IncrementScenarioCount();
        }

        [BeforeStep]
        public void BeforeStep()
        {
            var stepName = ScenarioStepContext.Current.StepInfo.Text;
            _step = _scenario.CreateNode<Given>(stepName); // Varsayılan olarak Given olarak oluşturulur
        }

        [AfterStep]
        public void AfterStep()
        {
            var stepName = ScenarioStepContext.Current.StepInfo.Text;

            if (ScenarioContext.Current.TestError == null)
            {
                _step.Pass("Passed");

                ExtentHelper.IncrementSuccessCount();
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

                ExtentHelper.IncrementFailureCount();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentHelper.FlushReport();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ExtentHelper.LogScenarioCounts();
        }
    }
}
