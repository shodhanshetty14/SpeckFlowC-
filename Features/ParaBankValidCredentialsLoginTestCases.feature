Feature: ParaBankValidCredentialsLoginTestCases

Test para Bank Website login functionality with Invalid Credentials.


Scenario:  Verify login for para Bank Website with Valid Credentials
	Given User is on the Para bank Login Page 
	When User enters valid  "<username>" and "<password>" in the input.
	When User clicks on the Login button 
	Then User is displayed with 

Examples: 
	| username     | password |
	| shodhan      | 12345    |
	| sharath      | 12345    |
