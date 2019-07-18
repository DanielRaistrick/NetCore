Feature: Tax
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Work out total net
	Given I have set the quantity to be 5
	And I have set the item Net to be 100
	When The total net is calculated
	Then the result should be 500 on the screen
