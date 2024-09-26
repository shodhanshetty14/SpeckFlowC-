Feature: ParaBankInvalidCredentialsLoginTesCases

Test para Bank Website login functionality with Invalid Credentials.


Scenario:  Verify login for para Bank Website with Invalid Credentials
	Given User is on the Para bank Login Page.
	When User enters the "<username>" and "<password>" in the input.
	When User clicks on the Login button.
	Then User is displayed with Invalid Credentials Message.

Examples: 
	| username | password |
	| abc      | abc123   |
	| xyz      | xyz@123  |
