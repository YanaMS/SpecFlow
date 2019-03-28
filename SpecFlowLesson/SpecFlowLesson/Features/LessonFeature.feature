Feature: LessonFeature 

@mytag
Scenario: Add two numbers and multiply 
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	And I have entered 2 into the calculator
    And Press Multiply
	Then the result should be 240 on the screen

Scenario: Add two numbers 
	Given I have entered values into the calculator as follow
	| Number |
	| 50     |
	| 30     |
	When I press add
	Then the result should be 90 on the screen
