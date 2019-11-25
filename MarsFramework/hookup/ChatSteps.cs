using MarsFramework.Global;
using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.hookup
{ 
    [Binding]
    public class ChatSteps:Base
    {
        SignIn login = new SignIn();
        [Given(@"I have logged into the portal sucessfully")]
        public void GivenIHaveLoggedIntoThePortalSucessfully()
        {
            login.LoginSteps();
        }
        
        [When(@"I click on chat")]
        public void WhenIClickOnChat()
        {
            IWebElement chat = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/a[1]"));
            chat.Click();

        }
        
        [Then(@"I would able to chat")]
        public void ThenIWouldAbleToChat()
        {
            IWebElement chat_text = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/input"));
            chat_text.SendKeys("Hi");
        }
    }
}
