using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.hookup
{
    
  
        [Binding]
        public class ChangePasswordSteps : Base
    { 
        SignIn login = new SignIn();
        Profile obj = new Profile();
        
            [Given(@"I have logged into the portal sucessfullhy")]
            public void GivenIHaveLoggedIntoThePortalSucessfullhy()
            {
                login.LoginSteps();
            }

            [Given(@"I have clicked on change password")]
            public void GivenIHaveClickedOnChangePassword()
            {
            obj.Hover();
            }

            [Then(@"I would be able to change the password sucessfully")]
            public void ThenIWouldBeAbleToChangeThePasswordSucessfully()
            {
            obj.ChangePwd();
            }
        }
    }

