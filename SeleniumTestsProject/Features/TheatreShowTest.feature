#Navigati catre pagina https://www.teatrulsicaalexandrescu.ro/?lang=en. 
#Dati click pe Team(engleza) si selectati prima persoana din echipa. Dati click pe primul spectacol al persoanei respective.
Feature: TheatreShowTest
	In order to buy a theatre ticket
	As a theatre lover
	I want to be able to see the show details

@Theatre
Scenario: TheatreShowDetails
	Given I go to the 'https://www.teatrulsicaalexandrescu.ro/?lang=en' website
	When I go to the first actor page
		And I choose the first show
	Then I should have the option to buy a ticket