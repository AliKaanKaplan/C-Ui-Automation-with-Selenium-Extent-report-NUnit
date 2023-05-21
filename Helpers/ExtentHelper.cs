using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AventStack.ExtentReports.Gherkin.Model;

namespace MeDirectUiProject.Helpers
{
    internal class ExtentHelper
    {
        private static ExtentReports _extent;
        private static ExtentTest _test;
        private static int _successCount = 0;
        private static int _failureCount = 0;
        private static int _scenarioCount = 0;
        public static ExtentReports GetExtent()
        {
            if (_extent == null)
            {
                string reportPath = @"C:\Users\k.kaplan\source\repos\MeDirectUiProject\Report_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";
                var htmlReporter = new ExtentHtmlReporter(reportPath);
                _extent = new ExtentReports();
                _extent.AttachReporter(htmlReporter);
            }
            return _extent;
        }

        public static ExtentTest CreateTest(string testName)
        {
            _test = _extent.CreateTest(testName);
            return _test;
        }

        public static void FlushReport()
        {
            _extent.Flush();
        }
        public static void AddScreenshotToReport(ExtentTest extentTest, string screenshotPath)
        {
            if (File.Exists(screenshotPath))
            {
                extentTest.Log(Status.Info, "Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            }
        }
        public static string TakeScreenshot(IWebDriver driver, string screenshotName)
        {
            string screenshotDirectory = @"C:\Users\k.kaplan\source\repos\MeDirectUiProject\Screenshots\";
            string screenshotFileName = $"{screenshotName}_{DateTime.Now:yyyyMMddHHmmssfff}.png";
            string screenshotPath = Path.Combine(screenshotDirectory, screenshotFileName);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            return screenshotPath;
        }

        public static void LogScenarioCounts()
        {
            _test.Log(Status.Info, $"Total Scenarios: {_scenarioCount}");
            _test.Log(Status.Info, $"Total Steps: {_successCount + _failureCount}");
            _test.Log(Status.Info, $"Successful Steps: {_successCount}");
            _test.Log(Status.Info, $"Failed Scenarios: {_failureCount}");

            _successCount = 0;
            _failureCount = 0;
            _scenarioCount = 0;
        }

        public static void IncrementSuccessCount()
        {
            _successCount++;
        }

        public static void IncrementFailureCount()
        {
            _failureCount++;
        }

        public static void IncrementScenarioCount()
        {
            _scenarioCount++;
        }

        public static ExtentTest CreateFeature(string featureName)
        {
            return _extent.CreateTest<Feature>(featureName);
        }

        public static ExtentTest CreateScenario(ExtentTest feature, string scenarioName)
        {
            return feature.CreateNode<Scenario>(scenarioName);
        }



    }
}
