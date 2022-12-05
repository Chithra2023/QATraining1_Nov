Feature: TMFeature

As a turnup portal user
I would like to create, edit & delete time & material records
So that I can manage emplyees' time and materials sucessfully


Scenario: Create time and material record with valid details
	Given I logged in to turnup portal sucessfully
	When I navigate to Time and Material page
	And I create a new Time and Material record
	Then The record should be created sucessfully
