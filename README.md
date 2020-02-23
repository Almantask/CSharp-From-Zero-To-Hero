# CSharp-From-Zero-To-Hero  
## Chapter 1. Homework 7: String 

### Intro
String is the ultimate type for expressing text through code.
In C#, you can do all sorts of things with string, such as splitting it, appending characters or other string or numbers to it, getting a number of characters and many more...
However, there is also an alternative- a class optimized for working with string- StringBuilder.
StringBuilder is a class which should be used when string is being interacted with within a loop.

### Task
You have an array of strings. Each element in array (a string) follows the same structure:  
*Name1, balanceX1, balanceX2, balanceX3*...  
*Name2, balanceY1, balanceY2, balanceY3*...  

So each line is a person with their balance history. The last balance in the array is their current amount of money they have. Currency in the balances is unspecified.  

You need to parse the balances and process them in the following ways:  
- ***FindHighestBalanceEver***- return name and balance(current) of person who had the biggest historic balance.  
- ***FindPersonWithBiggestLoss***- return name and loss of a person with a biggest loss (balance change negative).  
- ***FindRichestPerson***- return name and current money of the richest person.  
- ***FindMostPoorPerson***- return name and current money of the most poor person.  

Results of each operation have **to be printed using the TextTableBuilder**, using **padding = 3** (so **4 calls** to the TextTableBuilder).

Note: People and their balances can be found in: **PeopleBalances.cs, Balances** property.



 

 

