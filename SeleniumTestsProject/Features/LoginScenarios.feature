Feature: Login and logout
	In order to validate my account
	As a user
	I want to be able to login and logout

@login
Scenario: Login as admin
	Given I'm on the login page
	When I login with email admin.test3@gmail.com and password password123
	Then I should see the Deconectare button

@loginAndLogout
Scenario: Login and logout as admin
	Given I'm on the login page
	When I login with email admin.test3@gmail.com and password password123
	And I logout of the site
	Then I should see the login page