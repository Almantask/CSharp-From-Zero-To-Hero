# C#: From Zero To Hero
## Chapter 1. Homework 8: Files and errors
### Intro

#### File
We're all familiar with files- a place where some kind of data is placed. Text, binary, images or video- does not matter much.
File extension is also irrelevant, as it is a part of a name. It's all about the context and what reads a file.
Directory is a kind of a file too, which holds other files. File, is the first step to having data persistence beyond in-memory program state.

#### Errors
We already had to deal with the very first, also the most common error- NullReferenceException.
Errors is not a bad thing. They are an indicator that something went wrong.
We shouldn't hide errors and should allow them to happen.
Don't ignore errors, don't sweep them under a rug, but just don't catch them if you don't handle them explicitly.
Fail early, fail fast.

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

Results of each operation have **to be printed using the TextTableBuilder**, using **padding = 3** (so **4 calls** to the TextTableBuilder).

Note: People and their balances can be found in: **Input/Balances.corrupted** file. Example of clean balances can be found in **Input/Balances.clean** file



 

 

