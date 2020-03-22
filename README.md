# C#: From Zero To Hero
##Chapter 3: C#. Homework 3: Null related operators and more sugar
### Intro
C# is a modern high-level programming language. It has many nice features and it's time to explore some of it.
In particular, it's really cool the way C# handles null. There are several operators/patterns in regards to null handling and typecheck.
There is:
- ?. - null-conditional operator
- ?? - null-coalecense operator
- ? valueIfTrue : valueIfFalse - conditional operator
- value is Type1 - pattern matching  

A lot of neat quality of programmer life improvements provided by a language design. It's time to try it out!

### Task
Take (homework 1 assignment)[https://github.com/csinn/CSharp-From-Zero-To-Hero/tree/Chapter3/Homework/1/Src/BootCamp.Chapter]
and refactor it trying to apply the operators and functions learned in lesson- as much as you can.
Also apply null validation for every method and constructor:
1) Don't allow passing null references  
2) Don't allow passing null or empty strings
