Feature: AdministrationTests
	In order to manage the website
	As an admin user
	I want to be able to edit users 

#g.	Ca si admin, dati click pe buton de administrare.
@AdminMenu
Scenario: AccessAdminMenu
	Given I am logged in as admin
	When I navigate to Administration page
	Then I see the Site menu

#h.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.
@UsersMenu
Scenario: AccessUsersMenu
	Given I am logged in as admin
	When I go to Users page in the Administration section
	Then I see the users list

#i.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.
@EditUser
Scenario: EditUser
	Given I am logged in as admin
	When I go to Users page in the Administration section
		And I edit the user 'ad_demo@test.com'
	Then The user should be updated



