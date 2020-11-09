Feature: AddToCartTests
	In order to buy a product
	As a client
	I want to add the product to the cart

#b. Adaugati in cos un produs ca si utilizator.  -- fara sa fiu logat
@AddToCartAsGuest
Scenario: AddToCartAsGuest
	Given I navigate to home page
	When I add a product to the cart
	Then I need to login to complete the action

#c. Adaugati in cos un produs ca si admin.
@AddToCartAsAdmin
Scenario: AddToCartAsAdmin
	Given I am logged in as admin
	When I add a product to the cart
	Then I see the order button in my cart


