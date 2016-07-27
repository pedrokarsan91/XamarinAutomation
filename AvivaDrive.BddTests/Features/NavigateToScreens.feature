Feature: Navigate To Screens
	As a user 
	I  want to navigate to different screens
	So that I can see the relevant information

Scenario Outline: Navigate To Screens
	Given I navigate to "<Screen>"
	Then I should be in the "<ScreenTitle>" screen

	Examples: 
		| Screen             | ScreenTitle          |
		| Record             | Record Your Journey  |
		| Journeys           | My Journeys          |
		| Help               | Help & Feedback      |
		| Quote              | Get a Quote          |
		| My Badges          | My Badges            |
		| Settings           | Settings             |
		| Terms & Conditions | Terms and conditions |


