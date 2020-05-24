Feature: Greeter
	In order to do a demo
	I need to greet people first
	So that we avoid any rude reactions

@mytag
Scenario: Greet Person
	Given I have selected a language EN,
	When I greet a person with a name "Tom",
	Then the result should be "Hello, Tom!".
