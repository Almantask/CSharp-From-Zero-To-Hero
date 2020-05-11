# C#: From Zero To Hero
## Chapter 4: TDD
### Lesson 2: Mocking and Design for Testability

#### Intro
##### Testablity and tests
Testability is a design that should come naturally, following best coding practices. 
Not being able to test code simply means that the design is flawed and does not follow clean code principles.
It's not hard to test code that is written properly. However, make sure your tests are not just a safety net, but also living documentation.

##### Mocking
Black box tests- are the most common kind of tests- pass input to a function and get output.
However, often such tests are not enough, because our business requirements include internal calls, which are as important as the output.
For example a transfer of funds not only involves your balance being updated, but also a security check performed, identity verified.

Such checks and more, can only be verified by **mocks**. Use them when you want to setup custom test behaviour and verify the amount of time a method was called.
DO NOT test mocks, just use them to escape existing abstracted dependencies (whatever virtual methods).

Time to continue the journey of unit testing code. Try to use mocks where one class depends on another class (interface).

#### Task
Unit test ``/Gambling/Games``.  
Bonus: implement poker combo logic.
