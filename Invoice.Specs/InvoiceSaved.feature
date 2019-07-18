Feature: InvoiceSaved
	Checking that an invoice is actually saved to the database

@mytag
Scenario: An invoice is saved
	Given a user has entered invoice information	
	When the invoice is added
	Then invoice should be saved to the db
