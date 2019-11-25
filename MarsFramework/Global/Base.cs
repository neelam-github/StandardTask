using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Global
{
    public class Base 
    {
        //Initialise the browser
        public static IWebDriver driver { get; set; }
        #region To access Path from resource file

        public static int Browser = Int32.Parse(MarsResource.Browser);
        public static string ExcelPath = MarsResource.ExcelPath;
        public static string ScreenshotPath = MarsResource.ScreenShotPath;
        public static string ReportPath = MarsResource.ReportPath;
        public static string ReportXMLPath = MarsResource.ReportXMLPath;
        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        public static void ExtentReports()
        {
            

            extent = new ExtentReports(ReportPath, true, DisplayOrder.NewestFirst);

            extent.LoadConfig(ReportXMLPath);
        }
        #endregion

        #region setup and tear down
        [BeforeScenario]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {

                case 1:
                    driver = new FirefoxDriver();
                    break;
                case 2:
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl("http://www.skillswap.pro/");
                    break;

            }

            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(MarsResource.ReportXMLPath);

            #endregion

            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }

        }


        [AfterScenario]
        public void TearDown()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            driver.Close();
            driver.Quit();
        }

        
        #endregion

    }
}