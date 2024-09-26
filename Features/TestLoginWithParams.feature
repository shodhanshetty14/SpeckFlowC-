Feature: TestLoginWithParams
 
Test login with test data parameters

Background: 
	Given User is on Login Page 

@Regression
Scenario: Verify login functionality
	When User Enter username and password
	And User Clicks on Login button 
	Then User is navigated to home page 
 
@Sanity
Scenario Outline: Verify login with test parameters
	When User Enter "<username>" and "<password>"
	And User Clicks on Login button 
	Then User is navigated to home page
	Then User selected city and country information
| city      | country |
| Delhi     | India   |
| Boston    | USA     |


 
Examples: 
| username | password |
| tom      | Harry    |
| jerry    | Mathew   |


