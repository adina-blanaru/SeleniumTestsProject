﻿Feature: GoogleSearch
	In order to see images of Paris
	As a user
	I want to search on Google

@GoogleSearchParis
Scenario: GoogleSearchParis
	Given I go to Google website
	When I search for 'Paris'
	Then I should be able to expand the first image
		And Return to the results page