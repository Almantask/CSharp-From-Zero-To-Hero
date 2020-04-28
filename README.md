# C#: From Zero To Hero
## Chapter 3: C#. Homework 12: Operators overloading
### Intro
Objects are a center pieces of OOP. If we can put logic in an object without getting external services (or objects) involved, we should.
One way of putting logic into objects internally is through operators overloading.
We already know operators like +, -, ==, !=, (type), etc...
Now it's time to make our own way of implementing those operators!
### Task
In UK address can be defined like this:
   Nildram Ltd         [recipient]  
   Ardenham Court      [probably the building name: see Format Information.  Not all addresses have this part.]  
   Oxford Road         [street name]  
   AYLESBURY           [postal town (town/city)]  
   BUCKINGHAMSHIRE     [county (not needed)]  
   HP19 3EQ            [postal code]  
   UNITED KINGDOM      [country name]  
Postal office in UK has been having a problem for awhile now, that some mails have been duplicated (sent twice or more).
Find which postal office (by postal code) had the biggest amount of duplicates.  
Overload equality check operators, implicit operator from address to string.  

Addresses will be written in the following format:
```
Nildram Ltd
Ardenham Court
Oxford Road
AYLESBURY
BUCKINGHAMSHIRE
HP19 3EQ 
UNITED KINGDOM

Nildram Ltd
Ardenham Court
Oxford Road
AYLESBURY
BUCKINGHAMSHIRE
HP19 3EQ 
UNITED KINGDOM
```
Here you can see two addresses, which will be considered duplicate.