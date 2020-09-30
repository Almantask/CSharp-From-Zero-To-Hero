# C#: From Zero To Hero

## Chapter 1. Homework 4: Logical flow

### Introduction

In so many cases, code is not linear. We have conditions, which determine which path our code takes.
Such code multi-pathing is done using if statements.

If statement starts with `if` and then in bracked `()` we place a logical condition. Like so:

```cs
if(condition)
{
  // do something if condition is true
}
```

The scope (`{}`) is optional for one-liner statement, however it is recommended that you conventionally add the brackets. It's crucial that we do not miss the if statement branching logic and the extra brackets help even when they are not semantically needed.

Please note that you don't have to explicitly say that something is true or false in your if statement, if you are working with a bool value.
For example:

```cs
bool x = false;
if(x)
{
  // do something
}
```

If statements are especially useful when we need to validate input.
We aim to do the validation first and return as soon as we can, because that will allow us to care about the actual logic of a function without mixing it with mere validation.
For example, instead of this:

```cs
public static void Foo(string message)
{
  if(!string.IsNullOrEmpty(message))
  {
    if(another_condition)
    {
      // do something
      // bad! 3 levels deep!
    }
  }
}
```

do this:

```cs
public static void Foo(string message)
{
  if(string.IsNullOrEmpty(message)) return;
  if(!another_condition) return;
  // do something
  // good!- all is one level deep!
}
```

### Task

Modify your old functions to fit the specification:

1) Validate number input:
    - If input is not a number: print "{input} is not a valid number." and return -1.
    - If input is valid: return parsed input.
2) Validate name input:
    - If input is empty: print error message "Name cannot be empty." and return "-".
    - If input is not empty, return input.
3) Validate BMI input:
    - If height and/or weight being less or equal 0 print "Failed calculating BMI. Reason:" + all error messages and return -1.
    - Error messages:
      - "Height cannot be equal or less than zero, but was {input}."
      - "Weight cannot be equal or less than zero, but was {input}."

### Hints

* Do use Environment.NewLine if you want to concanate a string with a newline command (or use WriteLine).
* Be very careful where to place your NewLine's and where not!
* Do use [CultureInfo.InvariantCulture](https://docs.microsoft.com/de-de/dotnet/api/system.globalization.cultureinfo.invariantculture?view=netcore-3.1) when reading in float numbers. (Due to differences in parsing numbers with '.' and ',' character.
* The better your design, the easier it will be to find and fix errors!
* Be careful when it comes to the BMI. You have to use cm and m for the height.
