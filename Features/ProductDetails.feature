    Feature: Product Details Functionality
    Tests the proper functioning of basic features on the Product Details page.
    
    Background:
    Given User is on the login page

    Scenario: User back to products page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks random product image
     When User clicks back to products button
     Then User sees Products text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User add to cart a product from Product Detail page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 5 random product from Product Detail
     Then User sees the 5 of products
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User remove products from Product Detail page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 5 random product from Product Detail
     When User remove 5 random product from Product Detail
     Then User sees that the number of items in the basket has been reset.
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

      Scenario: The user sees the same picture on details page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 5 random product from Product Detail
     When User remove 5 random product from Product Detail
     Then User sees that the number of items in the basket has been reset.
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User sees same Product name on detail page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees same product name in 5 random products
     Examples:
    | UserName                | Password     | 
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User sees same Product Description on detail page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees same product description in 5 random products
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User sees same Product price on detail page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees same product price in 5 random products
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

    Scenario: User sees same Product image on detail page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     Then User sees same product image in 5 random products
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |
