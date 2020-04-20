# C#: From Zero To Hero
## Chapter 3. Homework 7: Delegates

### Intro
In C# functions are first class- meaning which they can be treated as parameters and be assigned to a variable.
This is quite useful, because it allows us to make extensible code form the outside.
Delegate almost replaces an interface in FP (functional programming) fashion, but to each- their own.
Another important benefit of delegates is events! We can start or stop listening to events and completely
decouple our code that way.

### Task
1) There a a file people.cs  
It contains info on different people such as : 
their birthday, name, surename, country, email, street address.
Parse it into people's list.  
2) Create a function Filter(Predicate<Person> people) combines all the predicates with "and" 
and returns true or false. Have different functions which fit the predicate for getting people by:   
a) over 18, who do not live in UK, whose surename does not contain letter 'a'.  
b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.  
c) who do not live in UK, whose surename and name does not contain letter 'a'.  
3) Demo this using events-based user input.  
Display controls, handle input presses for for the following events:  
a) DemoStarted  
b) Example selected (from 2) a, b, c)  
c) DemoEnded  
d) Application closed



 

 

