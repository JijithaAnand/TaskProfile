Feature: SpecFlowFeature1
    In order to update my profile 
    As a skill trader
    I want to add the Details that I know

@Automated
Scenario: Check if user could able to add a language 
    Given I clicked on the Language tab under Profile page
    When I add a new language
    Then that language should be displayed on my listings
    @Automated
    Scenario: Check if user could able to First and last Name
    Given  I clicked on the Language tab under Profile page
    When change first and last name
    Then the changes should be displayed
    
@Automated
    Scenario: Check if user could able to add skill
    Given  I clicked on the Skill tab under Profile page
    When I add a new Skill
    Then that Skill should be displayed on my listings
    @Automated
    Scenario: Check if user is able to edit Added language
    Given  I have logged into skillswap portal Navigate to Profile tab
    When I click on language to click on edit button for already added language
    Then the changes for language made should be displayed successfully
    @Automated
    Scenario: Check if user is able to delete Added language
    Given  I have logged into skillswap portal Navigate to Profile tab
    When I click on language tab and then click on delete button for already added language
    Then language should be deleted successufully

    @Non-Automated

    Scenario: Check if Avaliability Value gets saved
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on edit symbol on avalibility
    Then the changes made for avalibility should be displayed
    @Non-Automated
    Scenario: Check if hours Value gets saved
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on edit symbol on hours
    Then the changes made for hours should be displayed
    @Non-Automated
    Scenario: Check if Earn targets Value gets saved
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on edit symbol on Earn target
    Then the changes made for Earn target should be displayed

    @Non-Automated
    Scenario: Check if Description Value gets saved
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on description symbol on Description
    Then the changes made for Description should be displayed
    
    @Non-Automated
    Scenario: Check if user could able to add a Skill 
    Given I clicked on the Skill tab under Profile pages
    When I add a new skill
    Then that skill should be displayed on my listings
    @Non-Automated
    Scenario: Check if user is able to edit Added skill
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on skill tab and then click on edit button for already added skill
    Then the changes for skill made should be displayed successfully
    @Non-Automated
    Scenario: Check if user is able to delete Added skill
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on skill tab and then click on delete button for already added skill
    Then skill should be deleted successufully
    @Non-Automated
    Scenario: Check if user could able to add a Education 
    Given I clicked on the Skill tab under Profile pages
    When I add a new Education
    Then that Education should be displayed on my listings
    @Non-Automated
    Scenario: Check if user is able to edit Added Education
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on Education tab and then click on edit button for already added skill
    Then the changes for Education made should be displayed successfully
    @Non-Automated
    Scenario: Check if user is able to delete Added Education
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on Education tab and then click on delete button for already added skill
    Then Education should be deleted successufully
    @Non-Automated
    Scenario: Check if user is able to save Education with blank fields
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I add a new Education with fields blank
    Then Education doesn't gets saved and throws an error message
    @Non-Automated
    Scenario: Check if user could able to add a certification 
    Given I clicked on the certification tab under Profile page
    When I add a new certification
    Then that certification should be displayed on my listings
    @Non-Automated
    Scenario: Check if user is able to edit Added certification
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on certification tab and then click on edit button for already added skill
    Then the changes for certification made should be displayed successfully
    @Non-Automated
    Scenario: Check if user is able to delete Added certification
    Given  I have logged into skillswap portal Navigate to Profile tabs
    When I click on certification tab and then click on delete button for already added skill
    Then certification should be deleted successufully

   




	
	
	