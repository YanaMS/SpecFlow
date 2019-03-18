Feature: LessonFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers and multiply 
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	And I have entered 2 into the calculator
    And Press Multiply
	Then the result should be 240 on the screen
