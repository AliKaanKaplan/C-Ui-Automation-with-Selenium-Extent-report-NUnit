    Feature: Cart page Functionality
    Tests the proper functioning of basic features on the Cart.
    
    Background:
    Given User is on the login page

    Scenario: User goes to cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button   
     Then User sees Your Cart text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User see Card Quantity Label
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button   
     Then User sees QTY text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User see Description Label
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button   
     Then User sees Description text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User sees the added product on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button   
     Then User sees added product
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User removes the added product on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button   
     When User clicks remove button
     Then User sees that the number of items in the basket has been reset.
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User sees the quantity card on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button   
     Then User sees quantity card
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User sees product name on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button   
     Then User sees product name
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User sees product description on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button   
     Then User sees product description
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User sees product price on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button   
     Then User sees product price
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User clicks continue shopping button
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks continue shopping button
     Then User sees Products text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |