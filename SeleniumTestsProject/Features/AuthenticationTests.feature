Feature: AuthenticationTests
	In order to validate login
	As an admin user
	I want to authenticate into casqad.org

#@LoginUsingParams
#Scenario: ValidateLoginUsingParams
#	Given I navigate to authentication page
#	When I login with user 'admin.test3@gmail.com'
#		And password 'password123'
#	Then I am logged in

@LoginUsingDto
Scenario: ValidateLoginUsingDto
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail             | userPassword |
	| admin.test3@gmail.com | password123  |
	Then I am logged in

@LoginUsingExamples
Scenario Outline: ValidateLoginUsingExamples
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail        | userPassword		 |
	| <userEmailValue> | <userPasswordValue> |
	Then I am logged in

	Examples:
	| userEmailValue         | userPasswordValue |
	| admin.test3@gmail.com  | password123       |
	| invalid.user@gmail.com |                   |

@LoginUsingNullCheck
Scenario Outline: ValidateLoginNullCheck
	Given I navigate to authentication page
	When I login with following credentials
	| userEmail        |
	| <userEmailValue> |
	Then I am logged in

	Examples:
	| userEmailValue         | userPasswordValue |
	| admin.test3@gmail.com  |                   |
	| invalid.user@gmail.com | password123       |