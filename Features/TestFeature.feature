Feature: TestFeature

A short summary of the feature

@Regression
Scenario: Verify login functionality
	Given User is on Login Page
	When User Enter username and password
	And User Clicks on Login button 
	Then User is navigated to home page
