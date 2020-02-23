# C#: From Zero To Hero
## Chapter 1. Homework 4: Logical flow
### Introduction
In so many cases, code is not linear. We have conditions, which determine which path our code takes.
Such code multi-pathing is done using if statements.
If statements are especially useful when we need to validate the input.
We aim to do the validation first and return as soon as we can, because that will allow us to care about the actual logic of a function.

### Task
Modify your old functions to fit the specification:
1) Validate number input:
+ Input is not a number -> return -1.
+ Input is a number but 0 -> return 0.
+ Input is valid -> return input.
2) Validate name input:
+ Empty string for name -> return "-".
+ Print error message "Name cannot be empty." in a new line.
3) Validate BMI input:
+ Height and/or weight being less or equal 0 -> return -1.
+ Print error messages:
  - "Failed calculating BMI. Reason:"
  - "Height cannot be equal or less than zero, but was X.", where X is the console input (X <= 0)
  - "Weight cannot be equal or less than zero, but was X.", where X is the console input (X <= 0)
+ If height and weight are invalid print both messages, one in a new line each.
  - The error message of height does **NOT!!!!** contain **"equal or "** then!

### Hints
* Do use Environment.NewLine if you want to concanate a string with a newline command (or use WriteLine).
* Be very careful where to place your NewLine's and where not!
* Do use [CultureInfo.InvariantCulture](https://docs.microsoft.com/de-de/dotnet/api/system.globalization.cultureinfo.invariantculture?view=netcore-3.1) when reading in float numbers. (Due to differences in parsing numbers with '.' and ',' character.
* The better your design, the easier it will be to find and fix errors!
* Be careful when it comes to the BMI. You have to use cm and m for the height.
* Do not hesitate to ask mentors for advice. This homework IS puzzling.

### Tests Summary
The test results should be as pointed out below.

A stands for a valid value.
X, Y stand for invalid values.
R stands for valid value but not in the wanted range.
E stand for empty input string. (Just pressing enter when facing prompt.)
M stands for string message.

Format:
* Input -> return value
  * Output on same line as input.
* ~> User/Test input being A if valid, X if invalid.
* Output2 on new line.
  * Output3 on same line as Output2.

Checks.CalculateBmi(A, X) -> -1
* "Failed calculating BMI. Reason:"
* "Height cannot be equal or less than zero, but was X."
* ""

Checks.CalculateBmi(X, A) -> -1
* "Failed calculating BMI. Reason:"
* "Weight cannot be equal or less than zero, but was X."
* ""

Checks.CalculateBmi(X, Y) -> -1
* "Failed calculating BMI. Reason:"
* "Height cannot be less than zero, but was X."
* "Weight cannot be equal or less than zero, but was Y."
* ""

Checks.PromptString(M) -> "-"
* M
* ~> E
  * "Name cannot be empty."

Checks.PromptInt(M) -> 0
* M
* ~> E

Checks.PromptInt(M) -> -1
* M
* ~> A
  * "\\"A\\" is not a valid number."

Checks.PromptInt(M) -> -1
* M
* ~> R

Checks.PromptFloat(M) -> 0
* M
* ~> E

Checks.PromptFloat(M) -> -1
* M
* ~> A
  * "\\"A\\" is not a valid number."

Checks.PromptFloat(M) -> -1
* M
* ~> R
