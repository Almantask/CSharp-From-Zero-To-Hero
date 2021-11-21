
# C#: From Zero To Hero
## Chapter 3. Homework 6: Jagged array, 2D Array and Dictionary

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

Note: DO NOT CLEAR CONSOLE WITH ``Console.Clear()``;   
Use ``IGridCleaner.Clear()``

Extra: Draw a border arround the grid.
=======
# C#: From Zero To Hero 
# The vision
"Programming is hard". Yes, but not harder than running a marathon for a person who has never run. It's not harder than 
building a house if you never built one. Programming is hard only until you practice it (like any other skill). 
I would like to invite you to learn programming and C# following this course. 
Ignite passion for finding little miracles in code every day 🙂

# For new joiners
It's never too late to join, because the community is there, all the material is saved
and you will not be left alone.

Live lessons material (slides + videos + examples + homework) here:  
https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/Summary

New joiner's guide here:  
https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/New-joiner-guide  
![Boot Camp Banner](Res/kaisi_banner.png)

