# C#: From Zero To Hero
## Homework 7 & 8: LINQ and Extension Methods
## Intro
Extension methods allows us to bend outside code completely to our own needs.
Adding functions to an alredy existing code is neat and enables to put tightly related code to where it
belong- as member functions. We can make such methods on nearly anything: class, interface, enum. 
Generic or not- matters not! :)

LINQ (Language Integrated Query) as the name implies is meant for querying data.
Forget about a foreach loop in most cases, because LINQ nearly always replaces it.
LINQ allows easy, reasaonably fast data querying which makes writing code pure joy!

### Task
1) Create an extension method to shuffle elements inside a collection.  
2) Make your own LINQ method! Create a method SnapFingers which works like LINQ methods, 
takes a predicate and removes exactly half of all the elements in the collection.
If it's not even number, it should remove 1 less.  
For example:  
if it's 2, it removes 1;  
if it's 4, it removes 2;  
but if it's 3, it removes 1.  
3) Create any collection of any elements you want and do a demo for LINQ:  
Any
Count
Order
Sets
Union
Intersection
Subtraction
