Feature: OrangeHRM

Test Orange HRM Website login functionality.


Scenario: Verify login for Orange HRM Website
	Given User is on the Orange HRM Login Page
	When User enters the "<user>" and "<pass>" in input field.
	When User clicks on Login button
	Then User is navigated to Orange hrm home page

Examples: 
	| user  | pass     |
	| Admin | admin123 |
