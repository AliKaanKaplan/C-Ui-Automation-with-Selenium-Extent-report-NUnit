    Feature: Home Page Functionality
    Tests the proper functioning of basic features on the homepage.
    
    Background:
    Given User is on the login page

    Scenario: User selects filter Name(A to Z) from filter
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User select filter <FilterType>
     Then The user sees them correctly ordered from <FilterType>
     Examples:
    | UserName                | Password     | FilterType          |
    | standard_user           | secret_sauce | Name (A to Z)       |
    | standard_user           | secret_sauce | Name (Z to A)       |
    | standard_user           | secret_sauce | Price (low to high) |
    | standard_user           | secret_sauce | Price (high to low) |
    | problem_user            | secret_sauce | Name (A to Z)       |
    | problem_user            | secret_sauce | Name (Z to A)       |
    | problem_user            | secret_sauce | Price (low to high) |
    | problem_user            | secret_sauce | Price (high to low) |
    | performance_glitch_user | secret_sauce | Name (A to Z)       |
    | performance_glitch_user | secret_sauce | Name (Z to A)       |
    | performance_glitch_user | secret_sauce | Price (low to high) |
    | performance_glitch_user | secret_sauce | Price (high to low) |