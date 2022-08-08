Feature: SearchKeys

A short summary of the feature

@tag1
Scenario: I have 4 different keys and I don’t know which key starts my car
	Given I have 4 different keys
	When I try one by one of the keys with the car
	Then the correct key will start the car
