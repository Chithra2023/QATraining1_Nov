Feature: TMFeature

As a turnup portal user
I would like to create, edit & delete time & material records
So that I can manage emplyees' time and materials sucessfully


Scenario: Create time and material record with valid details
	Given I logged in to turnup portal sucessfully
	When I navigate to Time and Material page
	And I create a new Time and Material record
	Then The record should be created sucessfully

Scenario Outline: Edit existing material or time record with valid details
	Given I logged in to turnup portal sucessfully
	When I navigate to Time and Material page
	And I update '<Description>' of an existing Time & Material record
	Then The record should have an updated '<Description>'

Examples: 
	| Description |
	| Updated Desc 01  |
	| Desc 01  |
	| CN_Desc 03  |