Feature: TotalGrossSteps
	Check that the total gross is calculated correctly

@mytag
Scenario: Add two numbers
	Given I have an invoice with a quantity of 5
	And item net of 100
	And tax rate of 20
	When The invoice is created
	Then the total gross should be 600
