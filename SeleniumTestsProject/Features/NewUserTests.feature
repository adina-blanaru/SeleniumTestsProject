Feature: NewUserTests
	In order to access the website
	As a potential client
	I want to create an account

#d. Faceti inscrierea si logati-va cu noul cont.
@SignUp
Scenario: CreateAccountAndLogin
	Given I navigate to sign up page
	When I fill in the sign up form
	| Name         | Email          | Phone      | Address                     | Password |
	| AD Demo User | NewUniqueEmail | 0744123456 | Strada mea, Brasov, Romania | demo123? |
	Then My account is created 
		And I can login with credentials
		| userEmail      | userPassword |
		| NewUniqueEmail | demo123?     |

#e.	Logati-va si deconectati-va din site.
Scenario: LoginWithNewUser
	Given I am logged in as my demo user
	When I log out
	Then I am logged out

#f.	Dati click pe fiecare meniu (orizontal).
Scenario: SiteNavigation
	Given I am logged in as my demo user
	Then I should be able to access all the menus


