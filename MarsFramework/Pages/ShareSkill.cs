using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;


namespace MarsFramework.Pages
{
    internal class ShareSkill
    {

        /* public ShareSkill()
         {
             PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
         }

         //Click on ShareSkill Button
         [FindsBy(How = How.LinkText, Using = "Share Skill")]
         private IWebElement ShareSkillButton{ get; set; }

         //Enter the Title in textbox
         [FindsBy(How = How.Name, Using = "title")]
         private IWebElement Title;

         //Enter the Description in textbox
         [FindsBy(How = How.Name, Using = "description")]
         private IWebElement Description;

         //Click on Category Dropdown
         [FindsBy(How = How.Name, Using = "categoryId")]
         private IWebElement CategoryDropDown;

         //Click on SubCategory Dropdown
         [FindsBy(How = How.Name, Using = "subcategoryId")]
         private IWebElement SubCategoryDropDown;

         //Enter Tag names in textbox
         [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
         private IWebElement Tags;

         //Select the Service type
         [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
         private IWebElement ServiceTypeOptions;

         //Select the Location Type
         [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
         private IWebElement LocationTypeOption;

         //Click on Start Date dropdown
         [FindsBy(How = How.Name, Using = "startDate")]
         private IWebElement StartDateDropDown;

         //Click on End Date dropdown
         [FindsBy(How = How.Name, Using = "endDate")]
         private IWebElement EndDateDropDown;

         //Storing the table of available days
         [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
         private IWebElement Days;

         //Storing the starttime
         [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
         private IWebElement StartTime;

         //Click on StartTime dropdown
         [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
         private IWebElement StartTimeDropDown;

         //Click on EndTime dropdown
         [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
         private IWebElement EndTimeDropDown;

         //Click on Skill Trade option
         [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
         private IWebElement SkillTradeOption;

         //Enter Skill Exchange
         [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
         private IWebElement SkillExchange;

         //Enter the amount for Credit
         [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
         private IWebElement CreditAmount;

         //Click on Active/Hidden option
         [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
         private IWebElement ActiveOption;

         //Click on Save button
         [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
         private IWebElement Save;
         */
   
        IWebElement ShareSkillButton => Base.driver.FindElement(By.XPath(".//*[@class='ui basic green button']"));
        IWebElement Title => Base.driver.FindElement(By.Name("title"));
        IWebElement Description => Base.driver.FindElement(By.Name("description"));
        IWebElement CategoryDropDown => Base.driver.FindElement(By.Name("categoryId"));
        IWebElement SubCategoryDropDown => Base.driver.FindElement(By.Name("subcategoryId"));
        IWebElement Tags => Base.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        IWebElement ServiceTypeOptions => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        IWebElement LocationTypeOption => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        IWebElement Day => Base.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/form/div[7]/div/div[1]/ul[2]/li[2]/a")); 
        IWebElement Today => Base.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div/div[1]/ul[1]/li[1]/a"));
       
        //Click on Calender
        IWebElement StartEvent => Base.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/form/div[7]/div/div[1]/ul[1]/li[4]/a/span[1]"));
        //Double Click on a particular time row.
        IWebElement Time => Base.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/form/div[7]/div/table/tbody/tr[2]/td[2]/div/table/tbody/tr[7]/td[1]"));
        //Click on Event Title pop up
        IWebElement EventTitle => Base.driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[2]/input"));
        //Click on Event Calender
        IWebElement EndEvent => Base.driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[6]/span[1]/span/span/span[1]/span"));
        //Xpath For start time icon
        IWebElement S_Time => Base.driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[4]/span[1]/span/span/span[2]/span"));
        //XPath for exact start time
        IWebElement ExactStartTime => Base. driver.FindElement(By.XPath("/html/body/div[8]/div/ul/li[29]"));
        //XPath for end time icon
        IWebElement E_Time => Base.driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div[6]/span[1]/span/span/span[2]/span"));
        //Xpath for exact EndTime
        IWebElement ExactEndTime => Base.driver.FindElement(By.XPath("/html/body/div[11]/div/ul/li[31]"));
      
        //skill exchange checkbox
        IWebElement skillexchange => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
        //skill exchange tag
        IWebElement skillexchangetag => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        //credit checkbox
        IWebElement credit => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
        //credit amount
        IWebElement creditamount => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
        //Fileupload click button
        IWebElement clickfileupload => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        //Active checkbox
        IWebElement active => Base.driver.FindElement(By.Name("isActive"));
        //save button
        IWebElement save => Base.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
        internal void clickshareskill()
        {
            Wait.ElementVisible(Base.driver, ".//*[@class='ui basic green button']", "XPath");

            ShareSkillButton.Click();
        }
        internal void EnterShareSkill(string skilltrade)
        {



            //Wait.ElementVisible(Base.driver, "Title", "ClassName");
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");

            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            //choose category from dropdown
            CategoryDropDown.Click();
            SelectElement selectcategory = new SelectElement(CategoryDropDown);
            selectcategory.SelectByText("Programming & Tech");
            SubCategoryDropDown.Click();
            SelectElement selectsubcategory = new SelectElement(SubCategoryDropDown);
            selectsubcategory.SelectByText("QA");
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Firsttag"));
            Tags.SendKeys(Keys.Return);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Secondtag"));
            ServiceTypeOptions.Click();
            LocationTypeOption.Click();
            Day.Click();
            Today.Click();
            //Choose the start date from calender.
            StartEvent.Click();
            Calender.StartDate();
           // string day = "18";

            // /html/body/div[2]/div/div/table/tbody/tr[1]/td[1]/a
            ///html/body/div[2]/div/div/table/tbody/tr[1]/td[2]/a
           // int Days = 7;
            //string beforeXPath = "/html/body/div[2]/div/div/table/tbody/tr[";
           // string afterXPath = "]/td[";
           // Boolean Flag = false;
           // string dayVal = null;
            //For loops
           // for (int rownum = 1; rownum <= 7; rownum++)//Outer Loop
           // {
               // for (int colnum = 1; colnum <= Days; colnum++)//InnerLoop
               // {
                   // try
                   // {
                       // dayVal = Base.driver.FindElement(By.XPath(beforeXPath + rownum + afterXPath + colnum + "]/a")).Text;
                   // }
                   // catch (NoSuchElementException e)
                   // {
                   //  Console.WriteLine("Enter a correct date");
                   //     Flag = false;
                   // }

                   // Console.WriteLine(dayVal);
                    //if (dayVal.Equals(day))
                 //   {
                        //Base.driver.FindElement(By.XPath(beforeXPath + rownum + afterXPath + colnum + "]/a")).Click();
                        //Flag = true;
                       // break;
                   // }
               // }
               // if (Flag)
               // {
               //     break;
               // }
           // }
           
        
            
            //Double click on cell
            Actions actions = new Actions(Base.driver);
            actions.DoubleClick(Time).Perform();

            //Enter data on Event Title
            EventTitle.SendKeys("Skills Training");
            //Click on Event Calender
            EndEvent.Click();
            Thread.Sleep(5000);
            Calender.EndDate();
            //Click on startTime icon 
            S_Time.Click();
            //Click on exact start time
            Actions actions1 = new Actions(Base.driver);
            actions1.MoveToElement(ExactStartTime);
            actions1.Perform();

            //Click on Endtime icon
            E_Time.Click();
            //Click on exact end time
            Actions actions2 = new Actions(Base.driver);
            actions2.MoveToElement(ExactEndTime);
            actions2.Perform();

            ///html/body/div[10]/div/div/table/tbody/tr[1]/td[1]/a
            ///html/body/div[10]/div/div/table/tbody/tr[1]/td[2]/a

            if (skilltrade=="skillexchange")
            {
                skillexchange.Click();
                skillexchangetag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "skillexchangetag1"));
            }
            else
            {
                credit.Click();
                creditamount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "creditamount"));
            }
            //upload sample file
            //clickfileupload.Click();
            //AutoItX3 autoit = new AutoItX3();
            //autoit.Run("C:\\Abi\\Geethu\\Autoit\\FileUpload.exe");
            //Thread.Sleep(10000);
            //active.Click();
            //Thread.Sleep(7000);
            //save.Click();

        }

        internal void Editnfill(string skilltrade)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));
            SelectElement selectcategory = new SelectElement(CategoryDropDown);
            selectcategory.SelectByText("Writing & Translation");
            SubCategoryDropDown.Click();
            SelectElement selectsubcategory = new SelectElement(SubCategoryDropDown);
            selectsubcategory.SelectByText("Translation");
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Firsttag"));
            Tags.SendKeys(Keys.Return);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Secondtag"));
            ServiceTypeOptions.Click();
            LocationTypeOption.Click();
           // StartDateDropDown.Click();
            //StartDateDropDown.SendKeys("01112019");
            //EndDateDropDown.SendKeys("01122019");
            //chekbox1.Click();
            
           // checkbox2.Click();
            
            if (skilltrade == "skillexchange")
            {
                skillexchange.Click();
                skillexchangetag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "skillexchangetag1"));
                Tags.SendKeys(Keys.Return);
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "skillexchangetag2"));
            }
            else
            {
                credit.Click();
                creditamount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "creditamount"));
            }
            active.Click();
            save.Click();
        }
    }
}
