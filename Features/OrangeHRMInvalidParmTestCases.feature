Feature: OrangeHRMInvalidParmTestCases

Test Orange HRM Website with Invalid credentials for login functionality.

Scenario: Verify login for Orange HRM Website with Invalid Credentials
	Given User is on the Orange HRM Login Page.
	When User enters the "<username>" and "<password>" in input.
	When User clicks on Login button.
	Then User is displayed with Invalid Credentials.

Examples: 
	| user  | pass     |
	| amin | 7616761   |

