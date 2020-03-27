# C#: From Zero To Hero
## Chapter 1. Homework 6: Jagged array, 2D Array and Dictionary

### Intro
#### Jagged array and 2d array
Jagged and multidimensional arrays can be quite handy, 
when solving certain problems where there are actual dimensions.
For example, a chess board could be designed as a 2d array (board[,]). 
Excel sheet is a 2d array as well (sheet[,]).
A collection of queues could be a jagged array(queues[][])

#### Dictionary
Dictionaries are fast! That is true. But saying that they are faster than array or a list is silly.
If you access an element of dictionary, you access it through a key. Unlike index, which is an integer for array,
dictionary uses a key which first gets converted into a hashcode and only then used as an index to find an element.

### Task
1) Implement a console application where you can toggle any cell on a jagged array. 
Your program should start with asking for amount of rows in grid and then for each row in grid- its' legth.
After that, you can type x,y for example, to toggle that grid element on or off. 
Toggle ith asking for amount of rows in grid and then for each row in grid- its' legth. 
After that, you can type x,y for example, to toggle that grid element on or off. 
Toggle element should be filled with a black square. 
Toggling element which already contains a black square should remove the square.
2) Do the same for a 2d array, where you just ask for x and y dimensions. 
3) Given a sentence, find the symbol that repeats itself the most amount of times.