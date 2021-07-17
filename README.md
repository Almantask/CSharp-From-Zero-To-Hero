<<<<<<< HEAD
# C#: From Zero To Hero
## Chapter 1. Homework 5: Loops and Array
### Intro

#### Array
In programming, in so many cases we don't want just 1 variable, but many.
This is achieved using array- a data structure to hold many variables of the same type.
Array itself is a single variable and accessing elements in array is done through an index.
Array size is immutable (you cannot shrink the same array or expand it) and you can only change the values of individual array element by index.

#### Loop
In order to reduce redundant code to do something multiple times, we can use a loop.
A loop, as the name implies, repeats itself. 

For loop needs initial value; condition when the loop stops; and change of initial value;
While loop needs just has a condition which determines when it should stop.

### Task
Implement the following operations with array:
1) Sort array in ascending order
2) Inverse array
3) Remove first element from array
4) Remove last element from array
5) Remove element at a given index from array
6) Insert element at the start of array
7) Insert element at the end of array
8) Insert element at specified index of array

### Tests Summary
The test results should be as pointed out below.
Note that except for null and empty these are only examples to visualize what happens!

!IMPORANT!
Some of the tests below need extra validation.

Format: Input -> Output


1) **Sort array in ascending order**
	* null -> null
	* empty -> empty
	* { 1, 2, 3, 4, 5 } -> { 1, 2, 3, 4, 5 }
	* { 5, 4, 3, 2, 1 } -> { 1, 2, 3, 4, 5 }

2) **Inverse array**
	* null -> null
	* empty -> empty
	* { 1, 2, 3, 4, 5 } -> { 5, 4, 3, 2, 1 }
	* { 5, 4, 3, 2, 1 } -> { 1, 2, 3, 4, 5 }

3) **Remove first element from array**
	* null -> null
	* empty -> empty
	* { 1, 2, 3, 4, 5 } -> { 2, 3, 4, 5 }
	* { 5, 4, 3, 2, 1 } -> { 4, 3, 2, 1 }

4) **Remove last element from array**
	* null -> null
	* empty -> empty
	* { 1, 2, 3, 4, 5 } -> { 1, 2, 3, 4 }
	* { 5, 4, 3, 2, 1 } -> { 5, 4, 3, 2 }

5) **Remove element at a given index from array**
	* null -> null
	* empty -> empty
	* { 1, 2, 3, 4, 5 } -> { 1, 2, 4, 5 }  (index = 2)
	* { 5, 4, 3, 2, 1 } -> { 5, 4, 2, 1 }  (index = 2)

6) **Insert element at the start of array**
	* null -> { 0 }
	* empty -> { 0 }
	* { 1, 2, 3, 4, 5 } -> { 0, 1, 2, 3, 4, 5 }
	* { 5, 4, 3, 2, 1 } -> { 0, 5, 4, 3, 2, 1 }

7) **Insert element at the end of array**
	* null -> { 0 }
	* empty -> { 0 }
	* { 1, 2, 3, 4, 5 } -> { 1, 2, 3, 4, 5, 0 }
	* { 5, 4, 3, 2, 1 } -> { 5, 4, 3, 2, 1, 0 }

8) **Insert element at specified index of array**
	* null -> { 0 }
	* empty -> { 0 }
	* { 1, 2, 3, 4, 5 } -> { 1, 2, 0, 3, 4, 5 }  (index = 2)
	* { 5, 4, 3, 2, 1 } -> { 5, 4, 0, 3, 2, 1 }  (index = 2)
=======
# C#: From Zero To Hero 
# The vision
"Programming is hard". Yes, but not harder than running a marathon for a person has never run. It's not harder than 
building a house if you never built one. Programming is hard only until you practice it (like any other skill). 
I would like to invite you to learn programming and C# following this course. 
Ignite passion for finding little miracles in code every day 🙂

# New joiner guide
It's never too late to join, because the community is there, all the material is saved
and you will not be left alone.
Live lessons material (slides + videos + examples + homework) here: https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/Summary  
New joiner's guide here: https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/New-joiner-guide  
>>>>>>> Better intro to new joiners
