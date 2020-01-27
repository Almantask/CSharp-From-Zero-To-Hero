# CSharp-From-Zero-To-Hero

# Homework 3

## Hints
* Do use Environment.NewLine if you want to concanate a string with a newline command (or use WriteLine).
* Be very careful where to place your NewLine's and where not!
* Do use [CultureInfo.InvariantCulture](https://docs.microsoft.com/de-de/dotnet/api/system.globalization.cultureinfo.invariantculture?view=netcore-3.1) when reading in float numbers. (Due to differences in parsing numbers with '.' and ',' character.
* The better your design, the easier it will be to find and fix errors!
* Be careful when it comes to the BMI. You have to use cm and m for the height.
* Do not hesitate to ask mentors for advice. This homework IS puzzling.

## Task
1) Fork https://github.com/csinn/CSharp-From-Zero-To-Hero/tree/Chapter1/Homework/3
2) Take homework 2 code, place it in the forked branch and refactor it using functions. There should be as little duplicate code as possible (there should be functions for:
- Calculating BMI (weight comes in kg, height comes in meters),
- Prompt for input and converting it to int (print message for request, read console input and return converted input to int), 
- Prompt for input and converting it to string (print message for request, read console input and return input),
- Prompt for input and converting it to float (print message for request, read console input and return converted input to float).
3) Put all the function you made into the right places in Checks.cs class. Run tests, make sure you pass all the tests
4) Put all program.cs logic to Lesson3.cs. Call it from main function. Program class should look like this:

public class Program
{
  static void Main(string[] args)
  {
    Lesson3.Demo();
  }
} 

## Tests Summary
The test results should be as pointed out below.