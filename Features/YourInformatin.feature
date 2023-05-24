    Feature: Your Information page Functionality
    Tests the proper functioning of basic features on the homepage.
    
    Background:
    Given User is on the login page


     Scenario: User clicks checkout button
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button  
     When User clicks checkout button
     Then User sees Checkout: Your Information text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

     Scenario: User continue to checkout 
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks checkout button
     When User fills <FormUserName> <FormLastName> and <PostalCode> fields
     When User clicks continue button
     Then User sees <ConfirmText> text on page
     Examples:
    | UserName                | Password     | ConfirmText                    | FormUserName | FormLastName   | PostalCode |
    | standard_user           | secret_sauce | Checkout: Overview             | SampleName   | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | Checkout: Overview             | SampleName   | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | Checkout: Overview             | SampleName   | SampleLastName | SampleCode |
    | standard_user           | secret_sauce | Error: First Name is required  |              | SampleLastName | SampleCode |
    | problem_user            | secret_sauce | Error: First Name is required  |              | SampleLastName | SampleCode |
    | performance_glitch_user | secret_sauce | Error: First Name is required  |              | SampleLastName | SampleCode |
    | standard_user           | secret_sauce | Error: Last Name is required   | SampleName   |                | SampleCode |
    | problem_user            | secret_sauce | Error: Last Name is required   | SampleName   |                | SampleCode |
    | performance_glitch_user | secret_sauce | Error: Last Name is required   | SampleName   |                | SampleCode |
    | standard_user           | secret_sauce | Error: Postal Code is required | SampleName   | SampleLastName |            |
    | problem_user            | secret_sauce | Error: Postal Code is required | SampleName   | SampleLastName |            |
    | performance_glitch_user | secret_sauce | Error: Postal Code is required | SampleName   | SampleLastName |            |

     Scenario: User click cancel button navigate to cart page
     When User enters username <UserName> and password <Password> on login page
     When User clicks login button
     When User clicks cart button
     When User clicks checkout button
     When User clicks cancel button
     Then User sees Your Cart text on page
     Examples:
    | UserName                | Password     |
    | standard_user           | secret_sauce | 
    | problem_user            | secret_sauce | 
    | performance_glitch_user | secret_sauce | 