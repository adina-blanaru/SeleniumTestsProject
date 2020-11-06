Feature: DemoQaTests
	In order to practice my automation skills
	As a tester
	I want to be able to create an account and fill in a text form on demoqa.com

@CreateDemoQaAccount
#Navigati catre pagina https://demoqa.com/automation-practice-form. Completati TOATE campurile si apasati pe butonul de Submit.
Scenario: CreateDemoQaAccount
	Given I go to the 'https://demoqa.com/automation-practice-form' website
	When I fill in the registration form
	Then I should see the confirmation that the form was submitted

@DemoQaTextBox
#Navigati catre pagina https://demoqa.com/text-box. Completati TOATE campurile si apasati pe butonul de Submit.
Scenario: DemoQaTextBox
	Given I go to the 'https://demoqa.com/text-box' website
	When I fill in the text box form
	Then I should see the confirmation panel