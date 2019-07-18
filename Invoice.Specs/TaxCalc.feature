Feature: TaxCalc
	To test the basic tax calculation

@mytag
Scenario: Add two numbers
	Given I have set the quantity to be 5
	And I have set item net to be 100
	And I have set the tax Rate to be 20
	When the tax is calculated
	Then the resulting tax should be 100
