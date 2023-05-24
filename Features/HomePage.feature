    Feature: Home Page Functionality
    Tests the proper functioning of basic features on the homepage.
    
    Background:
    Given User is on the login page

    Scenario: User selects filter type from filter
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

    Scenario Outline: User navigeto to All Items Page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks random product image
     When User clicks menu button and clicks All Items submenu
     Then User sees Products text on page
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce | 
    | problem_user            | secret_sauce | 
    | performance_glitch_user | secret_sauce |

    Scenario Outline: User navigeto to Cart Page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     Then User sees Your Cart text on page
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce | 
    | problem_user            | secret_sauce | 
    | performance_glitch_user | secret_sauce |

    Scenario Outline: User navigeto to About Page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks random product image
     When User clicks menu button and clicks About submenu
     Then User sees about page
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce | 
    | problem_user            | secret_sauce | 
    | performance_glitch_user | secret_sauce |

    Scenario Outline: User reset app state
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 5 random product
     When User clicks menu button and clicks Reset App State submenu
     Then User sees that the number of items in the basket has been reset.
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce | 
    | problem_user            | secret_sauce | 
    | performance_glitch_user | secret_sauce |

    Scenario Outline: Different photos of all products
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees different photos of all products
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce | 
    | problem_user            | secret_sauce | 
    | performance_glitch_user | secret_sauce |

     Scenario: The user sees the number of products above the cart button
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 5 random product
     Then User sees the 5 of products
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce |  
    | problem_user            | secret_sauce |  
    | performance_glitch_user | secret_sauce | 