Feature: Standard Specification
	In order to evaluate storyq against specflow
	As a developer
	I want to have a look at the report generation
	And inspect the ways to generate specs

Scenario: Passing Test
	Given I have written a test
	When I run the test
	Then the test passes

Scenario: Failing Test
	Given I have written a test
	When I run the test
	Then the test fails

Scenario: Failing Test With Multiple Steps
	Given I have written a test
	When I run the test
	Then the test fails 
	But not in the last step

Scenario: Pending Test
	Given I have written a test
	When I run the test
	Then the test is pending

Scenario: Pending Test With Multiple Steps
	Given I have written a test
	When I run the test
	Then the test is pending
	But not in the last step