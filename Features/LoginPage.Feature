    Feature: Login Functionality
    Tests the proper functioning of basic features on the homepage.
    
    Background:
    Given User is on the login page

    @Positive
    Scenario Outline: User login with correct credentials
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees <Pop-up> text on page
     Examples:
    | UserName                | Password     | Pop-up                                              |
    | standard_user           | secret_sauce | Products                                            |
    | problem_user            | secret_sauce | Products                                            |
    | performance_glitch_user | secret_sauce | Products                                            |
    | locked_out_user         | secret_sauce | Epic sadface: Sorry, this user has been locked out. |

    @Positive
    Scenario Outline: User logout successfully
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks menu button and clicks Logout submenu
     Then User see login page
     Examples:
    | UserName                | Password     | Pop-up                                              |
    | standard_user           | secret_sauce | Products                                            |
    | problem_user            | secret_sauce | Products                                            |
    | performance_glitch_user | secret_sauce | Products                                            |

     @Negative
     Scenario Outline: User login with locked accounts
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees <Pop-up> text on page
     Examples: 
    | UserName       | Password       | Pop-up   |
    |                | wrong_password | Epic sadface: Username is required |
    | standart_user  |                | Epic sadface: Password is required |
    | wrong_username | wrong_password | Epic sadface: Username and password do not match any user in this service |
