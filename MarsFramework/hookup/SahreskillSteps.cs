using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.hookup
{
    [Binding]
    public class SahreskillSteps:Base
    {

        ShareSkill shareskillInstance = new ShareSkill();
        ManageListings manageListingsinstance = new ManageListings();
        [Given(@"I have navigated to the shareskill page")]
        public void GivenIHaveNavigatedToTheShareskillPage()
        {
            
            shareskillInstance.clickshareskill();
        }
        
        [When(@"I enter all the skill details and click save")]
        public void WhenIEnterAllTheSkillDetailsAndClickSave()
        {
            shareskillInstance.EnterShareSkill("credit");
        }
        
        [Then(@"added skill should be listed on my listing")]
        public void ThenAddedSkillShouldBeListedOnMyListing()
        {
            Assert.IsTrue(manageListingsinstance.searchskill("Seleniumwebdriver"));
        }
        [Given(@"I have navigated to the Manage Listing page")]
        public void GivenIHaveNavigatedToTheManageListingPage()
        {
            manageListingsinstance.ClickManageListing();
        }
       
        [When(@"I click on the write icon of the first skill in the listing")]
        public void WhenIClickOnTheWriteIconOfTheFirstSkillInTheListing()
        {
            manageListingsinstance.ClickEditSkill();
        }
        [When(@"edit the skill details and click save")]
        public void WhenEditTheSkillDetailsAndClickSave()
        {
            shareskillInstance.Editnfill("credit");
        }
        [Then(@"I should be able to see the skill on my listing")]
        public void ThenIShouldBeAbleToSeeTheSkillOnMyListing()
        {
            Assert.IsTrue(manageListingsinstance.searchskill("Malayalam to English Translation"));
        }

        [When(@"I click on the delete icon of the first skill in the listing")]
        public void WhenIClickOnTheDeleteIconOfTheFirstSkillInTheListing()
        {
            manageListingsinstance.ClickManageListing();
            manageListingsinstance.clickDeleteicon();
        }
        [Then(@"the respective skill should be deleted")]
        public void ThenTheRespectiveSkillShouldBeDeleted()
        {
            Assert.IsFalse(manageListingsinstance.searchskill("Malayalam to English Translation"));
        }

    }
}
