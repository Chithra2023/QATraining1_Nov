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
	And I update '<Description>','<Code>', '<Price>' of an existing Time & Material record
	Then The record should have an updated '<Description>', '<Code>' and '<Price>'

Examples: 
	| Description | Code | Price |
	| Updated 01  | CN1  | 30    |
	| Desc 01     | CN2  | 200   |
	| CN_Desc 03  | CN3  | 1000  |