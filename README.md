# C#: From Zero To Hero  
## Chapter 2. Homework 1: Encapsulation and intro to OOP  
### Intro
Object Oriented Programming starts with encapsulation. 
Encapsulation is 2 things really: 
1) Grouping of a strongly related data and functions;
2) Data hiding.  

OOP evolved from procedural programming. The whole point of it is to **reduce the scope we need to care about** at a time.
A class is a blueprint for objects and every object has its' own state.
We, humans, will make mistakes, the more freedom we are given.
Letting state mutate easilly is the last thing you want, therefore we **hide as much as we can**, 
so the public doesn't need to be bothered with choices they don't need to make.
Object state is defined by data. We don't want to recklesly mutate object state, therefore **we shouldn't expose data directly**.
The purpose of function is to mutate state: either of an object or an external resource.
**Only functions in a class should be public**, it should be the only way to mutate object's state. 
We **don't get or set data object an object directly, it is done through getter and setter methods**... 

### Task
You have an array of strings. Each element in array (a string) follows the same structure:  
*Name1, balanceX1, balanceX2, balanceX3*...  
*Name2, balanceY1, balanceY2, balanceY3*...  

So each line is a person with their balance history. The last balance in the array is their current amount of money they have. Currency in the balances is unspecified.  
All the data is stored in a file.  

However, something went wrong with the file and it got corrupted. It's not said what wrong, so you need to inspect the file and fix it.
There are 3 files in input folder:
- "Balances.corrupted"- the file you need to fix  
- "Balances.clean"- example of how a clean file should look like  
- "Balances.in"- the file which was used to generate the balances  

After the file is fixed, you need to parse the balances and process them in the following ways:  
- ***FindHighestBalanceEver***- return name and balance(current) of person who had the biggest historic balance.  
- ***FindPersonWithBiggestLoss***- return name and loss of a person with a biggest loss (balance change negative).  
- ***FindRichestPerson***- return name and current money of the richest person.  
- ***FindMostPoorPerson***- return name and current money of the most poor person.  

... and implement the following homework using the introductionary guidelines of OOP.

Note: If you did Chapter 1 Homework 8, then you can refactor homework to OOP code.  

 

 

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
