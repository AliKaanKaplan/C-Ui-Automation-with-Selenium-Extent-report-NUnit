Feature: Complete page Functionality
    Tests the proper functioning of basic features on the Complete.
    
    Background:
    Given User is on the login page
    
    Scenario: User sees Checkout Complete title
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button  
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     When User clicks finish button
     Then User sees Checkout: Complete! text on page
     Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode |

     Scenario: User sees thankfull message
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button  
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     When User clicks finish button
     Then User sees Thank you for your order! text on page
     Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode |


     Scenario: User sees arriving message
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button  
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     When User clicks finish button
     Then User sees Your order has been dispatched, and will arrive just as fast as the pony can get there! text on page
     Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode |

     Scenario: User clicks back home button navigate to Homo page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button  
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     When User clicks finish button
     When User clicks back home button
     Then User sees Products text on page
     Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode |

     Scenario: User sees Successfull order sign
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User add to cart 1 random product
     When User clicks cart button  
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     When User clicks finish button
     Then User sees Successfull order sign
     Examples:
    | UserName                | Password     | FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | SampleName   | SampleLastName | SampleCode |