Feature: GoogleNewsHeadlineFeature



Scenario: Print All headline on a page
	Given I navigated to Google news website
	And the Google headlines page is loaded successfully
	Then I must be able to print all headline on the page