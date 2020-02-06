# CSharp-From-Zero-To-Hero

# Homework 6

## My debug steps to solve the values and passphrase
I set a break point at line 51 of Program.cs, started the debugger, and stepped into the code. 
I kept on stepping into the code to see the values of the variables in the Locals window. 
That is how I figured the answers to the questions and the passphrase.

*Answers:
*Debugger!
*51
*79
*77
*A minore ad maius a solis ortu usque ad occasum ab uno disce omnes


## Hints
* There are no tests to pass in this homework.
* Make **sure** that you opened Bootcamp.sln!
* This homework's task is to give you a playful experience with the debug mode.
* This homework is very easy if you know what happens and what to do.
* You don't have to change the code at all.
* You are only supposed to set breakpoints and click the debug button.
* To prevent you from cheating we had to go for stuff that is out of your current scope.
  * To be exact this scope is not even present in the near future.
  * Do not try to understand how everything is exactly working out. We will explain this when you're ready for this!
* You are able to solve this by simply observing the console output. Nothing else is needed!

## Task
1) Open Program.cs.
2) Add one or more breakpoints to your code.
  * Rightclick a line of code (`Console.WriteLine();` for example.
  * Search for **Breakpoint** menu option.
  * Click **Add Breakpoint** in the submenu.
  * Look to the left. A red circle should have appeard.
  * Remember this vertical bar of the circle!
  * You can add or remove breakpoints by clicking this bar.
    * Try it! Click the red circle once. It will disappear.
    * Click again and the circle appears again.
3) Run code in debug mode.
  * Click the green arrow in the upper screen (rather left) with "BootCamp.Chapter" on it.
  * Now the program will run until it's first breakpoint.
  * The line of the breakpoint will **not** execute until you press the green button "Continue" again. (Simplified)
    * This means that said `Console.WriteLine();` will not print a new line before you did click "Continue".
    * Remember this very well! Otherwise this will lead to confusion in later homeworks - most likely.
