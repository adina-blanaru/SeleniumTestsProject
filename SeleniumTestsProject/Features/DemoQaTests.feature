Feature: DemoQaTests
	In order to practice my automation skills
	As a tester
	I want to be able to create an account and fill in a text form on demoqa.com

@CreateDemoQaAccount
#Navigati catre pagina https://demoqa.com/automation-practice-form. Completati TOATE campurile si apasati pe butonul de Submit.
Scenario: CreateDemoQaAccount
	Given I go to the 'https://demoqa.com/automation-practice-form' website
	When I fill in the registration form
	| FirstName       | LastName       | Email             | Gender | MobilePhone | DateOfBirth | Subjects             | Hobbies       | PictureName  | CurrentAddress               | State   | City    |
	| Test First Name | Test Last Name | testuser@test.com | Female | 4123456789  | 03/12/1970  | Maths, Arts, English | Sports, Music | test-img.JPG | My current street 11, BV, RO | Haryana | Panipat |
	Then I should see the confirmation that the form was submitted

@DemoQaTextBox
#Navigati catre pagina https://demoqa.com/text-box. Completati TOATE campurile si apasati pe butonul de Submit.
Scenario: DemoQaTextBox
	Given I go to the 'https://demoqa.com/text-box' website
	When I fill in the text box form
	| FullName            | Email             | CurrentAddress               | PermanentAddress               |
	| Test User Full Name | testuser@test.com | My current street 11, BV, RO | My permanent street 13, BV, RO |
	Then I should see the confirmation panel