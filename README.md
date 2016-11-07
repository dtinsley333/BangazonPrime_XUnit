# Intro to TDD (Test Driven Development) BangazonPrime XUnit
TDD examples for Bangazon Prime

##What you will learn.
You will learn to create failing tests based on requirements, better known as acceptance criteria. Tests will come before implementation code. You will learn to run and refactor tests. You will gain an understanding how creating the test first forces you to plan how your code will be implemented without writing a line of implementation code. You will learn that creating tests can not only be beneficial for new code but also of great value for ensuring bugs are fixed and tests are implemented. Your will learn that code changes may break existing tests, that is not a bad thing, that lets you examine if the test needs to changed based on code changes. Another benefit of tests is their role in continuous integration where tests are ran prior to being pushed to source control or other environments. Your test should document how your code is supposed to behave. Commented out tests are a kind of technical debt that should be addressed. 

Prior to working on existing code you should pull the latest code then run the tests. All tests should pass. Create new tests for new functionality or bug fixes. Make sure all existing tests still pass and all new tests still pass. 
##Myths about Test Driven Development (TDD)
TDD is just about testing
TDD slows down development
TDD means creating lots of interfaces
TDD guarantees you to catch all the potential errors in a system
TDD guarantees you to design your system well



https://en.wikipedia.org/wiki/Test-driven_development
http://bitbybitblog.com/introduction-to-test-driven-development/

###This code is an simple TDD example. 
MAIN TDD STEPS (Red to Green Tests):
   1. Write the test prior to writing code.
   2. Run all tests and see if the new test fails
   3. Write the code to satisfy the test
   4. Run tests, refactor and fix until the test passes
   5. Refactor, clean up refine, make sure you are meeting acceptance criteria
   6. Repeat 


##Clone the Example app from https://github.com/dtinsley333/BangazonPrime_XUnit.git
A few of the tests work already, some don't.

1. Fix the current tests that don't work by creating code that turns the red broken test to green passing tests. 
2. Create tests for allowing sellers to create products that are Bangazon Prime.
3. Add test to test that a product of the type holiday movie is eligible for Bangazon prime from October to January. User must also have a Bangazon Prime Membership.
4. Create a test that tests that users without Bangazon Prime are offered Bangazon Prime at a discount on Black Friday.   
5. Create a test that returns a list containing products featured in "Deal of the Day". All products must be Bangazon Prime eligible. 
   


