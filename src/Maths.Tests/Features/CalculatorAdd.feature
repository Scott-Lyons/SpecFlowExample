Feature: CalculatorAdd
	As a user
	I would like an add method on my calculator
	So that I don't have to manually add numbers together

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120

Scenario: Add a list of numbers
	Given a list of numbers
	| Value |
	| 50    |
	| 75    |
	| 75    |
	And the numbers are entered into the calculator
	When I press add
	Then the result should be 200