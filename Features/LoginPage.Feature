    Feature: Login Functionality
    Tests the proper functioning of basic features on the homepage.
    
    Background:
    Given User is on the homepage
    When Enter the URL

    Scenario Outline: Successful Login with Valid Credentials
    When User enter <UserType> and secret_sauce
    Examples:
    | UserType  |
    | standard_user     | 
    | locked_out_user      | 
    | problem_user         |
    | performance_glitch_user |

    Scenario: Login input Visibility Test 
    Then User should see username textbox

    Scenario: Password input Visibility Test 
    Then User should see password textbox

    Scenario: Login Button Visibility Test
    Then User should see login button
    