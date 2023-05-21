    Feature: Home Page Functionality
    Tests the proper functioning of basic features on the homepage.
    
    Background:
    Given User is on the homepage
    When Enter the URL

    Scenario Outline: User should see home page
    When User enter <UserType> and secret_sauce
    Examples:
    | UserType  |
    | standard_user     | 
    | locked_out_user      | 
    | problem_user         |
    | performance_glitch_user |

    Scenario: User should see Login input
    Then User should see username textbox

    Scenario: User should see Password input
    Then User should see password textbox

    Scenario: User should see Login button
    Then User should see login button
    