using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace MeDirectUiProject.Helpers
{
    internal class ExtentHelper
    {
        private static ExtentReports _extent;
        private static ExtentTest _test1;

        // Get the ExtentReports instance
        public static ExtentReports GetExtent()
        {
            if (_extent == null)
            {
                // Define the path for the report

                string reportDirectory = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName, "..\\Report");
                Directory.CreateDirectory(Path.GetDirectoryName(reportDirectory));
                string reportPath = Path.Combine(reportDirectory, $"TestReport_{DateTime.Now:yyyyMMddHHmmss}.html");



                // Create an HTML reporter and attach it to ExtentReports
                var htmlReporter = new ExtentHtmlReporter(reportPath);
                htmlReporter.Config.DocumentTitle = "Test Report";
                htmlReporter.Config.ReportName = "MeDirect Assignment Report";

                _extent = new ExtentReports();
                _extent.AttachReporter(htmlReporter);
            }
            return _extent;
        }

        // Create a new test in the report
        public static ExtentTest CreateTest(string testName)
        {
            _test1 = _extent.CreateTest(testName);
            return _test1;
        }

        // Flush the report to save changes
        public static void FlushReport()
        {
            _extent.Flush();
        }

        // Add a screenshot to the report
        public static void AddScreenshotToReport(ExtentTest extentTest, string screenshotPath)
        {
            if (File.Exists(screenshotPath))
            {
                extentTest.Log(Status.Info, "Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build());
            }
        }

        // Take a screenshot and save it to a file
        public static string TakeScreenshot(IWebDriver driver, string screenshotName)
        {
            string screenshotDirectory = Path.Combine(Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName, "..\\Screenshots");
            string screenshotFileName = $"{screenshotName}_{DateTime.Now:yyyyMMddHHmmssfff}.png";
            string screenshotPath = Path.Combine(screenshotDirectory, screenshotFileName);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            return screenshotPath;
        }

        // Create a new feature in the report
        public static ExtentTest CreateFeature(string featureName)
        {
            return _extent.CreateTest<Feature>(featureName);
        }

        // Create a new scenario under a feature in the report
        public static ExtentTest CreateScenario(ExtentTest feature, string scenarioName)
        {
            return feature.CreateNode<Scenario>(scenarioName);
        }

        // Sanitize a file name by removing invalid characters
        public static string SanitizeFileName(string fileName)
        {
            string invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            foreach (char c in invalidChars)
            {
                fileName = fileName.Replace(c.ToString(), "");
            }
            return fileName;
        }
    }
}
