# Testing / Mocks Practice

I've got a `DiceRoller` class here that needs to be tested. I've got
a partial test suite started in *TestingRandomTests/DiceRollerTests.cs*, 
but it's got some problems. 

`DiceRoller.Roll(string)` accepts an input string formatted like a Dungeons
and Dragons dice roll. For example, *1d6* means roll a six-sided die one time, 
*2d8* means roll an eight-sided die twice, and so on.

## Task 

(1) `Roll_Never_Out_Of_Range` - Looping the action to test over and over
is a pretty bad way of testing Roll. Figure out a better way to test and 
make sure it's never out of range.

(2) Figure out how to test making sure that the `DiceRoller` calls into
the `IRandomizer` the right number of times with the right argument.

Don't change `DiceRoller` to make this happen. You should only make
changes to the test project. 

You are not limited in the 
mocking technique / library you use. (In other words, you are to find a 
mocking library or implement the mocks yourself - *what* you're expected 
to test is the same).