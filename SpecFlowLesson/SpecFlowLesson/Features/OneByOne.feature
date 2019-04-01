Feature: OneByOne
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@OneByOne
Scenario: Add two numbers OneByOne
	Given I have entered values into the calculator as follow
	| Number |
	| 2      |
	And I have entered values into the calculator as follow
	| Number |
	| 30     |
	When I press add
	Then the result should be 80 on the screen
