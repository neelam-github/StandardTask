using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        /* public ManageListings()
         {
             PageFactory.InitElements(Global.Base.driver, this);
         }
        
         //Click on Manage Listings Link
         [FindsBy(How = How.LinkText, Using = "Manage Listings")]
         private IWebElement manageListingsLink { get; set; }

         //View the listing
         [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
         private IWebElement view { get; set; }

         //Delete the listing
         [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
         private IWebElement delete { get; set; }

         //Edit the listing
         [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
         private IWebElement edit { get; set; }

         //Click on Yes or No
         [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
         private IWebElement clickActionsButton { get; set; }
 */
        //Click on Manage Listings Link
        IWebElement managelisting => Base.driver.FindElement(By.XPath(".//*[@class='ui eight item menu']/a[3]"));
        
        //go to next page
        IWebElement gotonextpage => Base.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div/button[10]"));
        //click on the edit write icon
        IWebElement editwriteicon => Base.driver.FindElement(By.XPath(".//*[@class='ui striped table']/tbody/tr[1]/td[8]/i[2]"));
        //click on delete icon
        IWebElement deleteicon => Base.driver.FindElement(By.XPath(".//*[@class='ui striped table']/tbody/tr[1]/td[8]/i[3]"));
        //Title of the first item
        IWebElement titleoffirstelement => Base.driver.FindElement(By.XPath(".//*[@class='ui striped table']/tbody/tr[1]/td[3]"));
        //click on yes or no
        IWebElement clickActionsButton => Base.driver.FindElement(By.XPath("//button[contains(.,'Yes')]"));
        public bool searchskill(string newtitle)
        {
            //Populate the Excel Sheet
           // GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            //managelisting.Click();
            try
            {
                //start the report
                Base.ExtentReports();
                Thread.Sleep(1000);
                Base.test = Base.extent.StartTest("search skill");
                while (true)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        Wait.ElementVisible(Base.driver, "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[1]/td[3]", "XPath");
                        //Identify title element
                        IWebElement Title = Base.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[3]"));
                        Console.WriteLine(Title.Text);
                        if (Title.Text == newtitle)
                        {
                            Base.test.Log(LogStatus.Pass, "Test Passed");
                            SaveScreenShotClass.SaveScreenshot(Base.driver, "sucessfull");
                            return true;
                        }

                    }
                    gotonextpage.Click();
                }

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                return false;
            }

        }
        internal void ClickManageListing()
        {
            Wait.ElementVisible(Base.driver, "//*[@id='service-listing-section']/section[1]/div/a[3]", "XPath");
            managelisting.Click();
        }
        //Edit the first skill in list
        internal  void ClickEditSkill()
        {
           
            Wait.ElementVisible(Base.driver, ".//*[@class='ui striped table']/tbody/tr[1]/td[8]/i[2]", "XPath");
            editwriteicon.Click();

        }

        public void clickDeleteicon()
        {
            
            Wait.ElementVisible(Base.driver, ".//*[@class='ui striped table']/tbody/tr[1]/td[8]/i[3]", "XPath");
            deleteicon.Click();
            //Click Yes in the poped window
            // Base.driver.SwitchTo().Alert().Accept();
            clickActionsButton.Click();
        }
       /* public bool Validatefirstitem(string newtitle)
        {
            
            try
            {
                if (titleoffirstelement.Text == newtitle)
                {
                    
                            Base.test.Log(LogStatus.Pass, "Test Passed");
                            SaveScreenShotClass.SaveScreenshot(Base.driver, "sucessfull");
                            
                }

            }

            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                
            }
            
        }
   */
    }

}
