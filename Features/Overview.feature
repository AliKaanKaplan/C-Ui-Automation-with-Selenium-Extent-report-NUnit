    Feature: Overview Functionality
    Tests the proper functioning of basic features on the Overview.
    
    Background:
    Given User is on the login page
    
    Scenario: User goes to Overview page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     Then User sees Checkout: Overview text on page
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

        
    Scenario: User see Card Quantity Label
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button 
     Then User sees QTY text on page
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

    Scenario: User see Description Label
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button  
     Then User sees Description text on page
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

     Scenario: User sees the quantity card on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button  
     Then User sees quantity card
        Examples:
      | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

    Scenario: User sees product name on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button 
     Then User sees product name
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

     Scenario: User sees product description on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button 
     Then User sees product description
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

     Scenario: User sees product price on the cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button  
     Then User sees product price
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |

     Scenario: User clicks to cancel navigate to home page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button  
     When User clicks cancel button
     Then User sees Products text on page
        Examples:
    | UserName                | Password     |  FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce |  SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce |  SampleName   | SampleLastName | SampleCode |


     Scenario: User sees Invoice tag title
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button  
     Then User sees <ConfirmText> text on page
        Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode | ConfirmText          |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode | Payment Information  |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode | Payment Information  |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode | Payment Information  |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode | Shipping Information |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode | Shipping Information |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode | Shipping Information |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode | Price Total          |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode | Price Total          |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode | Price Total          |

     Scenario: User sees correctly calculated total price
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button  
     Then User sees correct total price
        Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode | 
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode | 
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode |