Feature: SpecFlowFeature1
	Simple test to show that ReSharper 2021.3.1 does not execute custom OneTimeSetUp with Specflow 3.1.97.

@mytag
Scenario: Perform the test with ReSharper 2021.2.2, then try with ReSharper 2021.3.1
	Given Let's set some assumptions
	When The test is run
	Then the test shall pass