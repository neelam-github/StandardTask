Feature: Sahreskill
	As a skill trader I should be able to add the details of the skill that I like to exchange
	And manage those skills on my listing

@mytag
Scenario: Enterskillandvalidate
	Given I have navigated to the shareskill page
	When I enter all the skill details and click save
	Then added skill should be listed on my listing


	Scenario: Editskillandvalidate
	Given I have navigated to the Manage Listing page
	When I click on the write icon of the first skill in the listing
	And  edit the skill details and click save
	Then I should be able to see the skill on my listing

	Scenario: Deleteskillandvalidate
	Given  I have navigated to the Manage Listing page
	When I click on the delete icon of the first skill in the listing
	Then the respective skill should be deleted