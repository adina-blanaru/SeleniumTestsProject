#Navigati catre pagina https://untold.com/. Dati click pe meniu si selectati pagina HOME.
Feature: UntoldTest
	In order to find more details about Untold
	As a festival lover
	I want to see the festival home page

@Untold
Scenario: UntoldHomePage
	Given I go to the 'https://untold.com/' website
	When I go to home page from the navigation menu
	Then I should see the home page