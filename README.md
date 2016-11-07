# Intro to TDD (Test Driven Development) Test the Bangazon Prime Feature using XUnit
TDD example for Bangazon Prime

###Bangazon Prime is a customer reward feature of a fictional company called Bangazon Prime Inc.
It provides many benefits such as free shipping on many products, daily specials, black friday specials, free streaming of many movies. 

##What You Will Learn.
Tests enable you be confident that new code or refactoring does not break existing code. Writing tests prior to writing new code will help you discover how to implement the requirements. In addition your code will be testable from the onset rather than testable code being an after thought. You will learn to create failing tests based on requirements, better known as acceptance criteria. Your tests should document how your code is supposed to behave according to your acceptance criteria.  In TDD, tests are written PRIOR to implementation code. You will learn to run and refactor tests. You will learn that creating tests can not only be beneficial for new code but also of great value for ensuring bugs are fixed and tests are implemented around the bug fix. You will find that code changes may break existing tests, that is not a bad thing, it indicates the test needs to modified based on code changes.  Another benefit of tests is their role in continuous integration where tests are ran prior to being pushed to source control or even deployed to test or production environments. 

Prior to working on existing code you should pull the latest code then run the tests. All tests should pass. Create new tests for new functionality or bug fixes. Make sure all existing tests still pass and all new tests pass. 
##Myths About Test Driven Development (TDD)
   * TDD is just about testing
   * TDD slows down development
   * TDD means creating lots of interfaces
   * TDD guarantees you to catch all the potential errors in a system
   * TDD guarantees you to design your system well

https://en.wikipedia.org/wiki/Test-driven_development
http://bitbybitblog.com/introduction-to-test-driven-development/


###MAIN TDD STEPS (Red to Green Tests):
   1. Write the test prior to writing code.
   2. Run all tests and see if the new test fails
   3. Write the code to satisfy the test
   4. Run tests, refactor and fix until the test passes
   5. Refactor, clean up refine, make sure you are meeting acceptance criteria
   6. Repeat 

##Clone the Example app from https://github.com/dtinsley333/BangazonPrime_XUnit.git

##Running the code
The application can be opened in Visual Studio Code. Which can be downloaded here: http://code.visualstudio.com/B?utm_expid=101350005-31.YsqwCVJESWmc4UCMDLsNRw.1&utm_referrer=https%3A%2F%2Fsearch.yahoo.com%2F This code will run on OSX as well as windows. 
####Steps: 
* Open the code in Visual Studio Code
* CD to the src folder and enter the command dotnet build--C:\CodeProjects\BangazonPrime_XUnit\src\BangazonPrimeService>dotnet build
* CD to the test folder and enter the dotnet build.--C:\CodeProjects\BangazonPrime_XUnit\test\BangazonPrimeServiceTests dotnet build
* There will be errors to fix. Once fixed 
* Enter the command dotnet test--C:\CodeProjects\BangazonPrime_XUnit\test\BangazonPrimeServiceTests dotnet test
* Some tests will fail. See instructions below regarding fixing the broken tests as well as creating new tests for new functionality.


A few of the tests work already, some don't. Fix the existing broken tests and create tests for yet to be implemented functionality. After creating the new tests they will fail. Create code that enables the tests to pass. See the requirements below that you need to use TDD to solve. This work will involve creating the tests then writing the code to satisfy the the test. You will find you need to refactor your code as well as the test several times to get the results you want. 

####Assignment:
 1. Create a test to make sure movies that are not eligible for streaming are indeed not eligible.
 2. Create tests for allowing sellers to create products that are Bangazon Prime.
 3. Add test to test that a product of the type holiday movie is eligible for streaming by Bangazon Prime customers from October to   January. User must also have a Bangazon Prime Membership.
 4. Create a test that tests that users with Bangazon Prime are offered Bangazon Prime at a discount on Black Friday.
 5. Create a test that returns a list containing products featured in "Deal of the Day". All products must be Bangazon Prime eligible. list containing products featured in "Deal of the Day". All products must be Bangazon Prime eligible. 
   


