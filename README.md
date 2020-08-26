# C#: From Zero To Hero. Chapter 2: OOP. Lesson 3: Polymorphism

## Polymorphism

What does a plane and a bird have in common? 
- They can fly. Unified by behaviour. If all animals can move, then we don't need to know the specific of each animal in order to make them move.
The application of polymorphism is immense in OOD (object oriented design) and today you will get your hands dirty (clean actually :)) with it.

## Task

Let's make some factories! 
There are 2 factories:
WindowsFactory- makes windows PCs.  
MacFactory- makes Mac PCs.  

2 factories have the exact same flow when assembling a PC:
1) Prepare body
2) Install CPU
3) Install RAM
4) Install GPU
5) Install Cooler
6) Install Motherboard

However individual steps are different for each: 
Mac: Install Mac Body, Install Mac CPU, Install Mac RAM...
Win: Install Win Body, Install Win CPU, Install Win RAM...

Implement both factories, so that each maintain the same flow for assembling pcs. 

Create 2 mac factories, 2 win factories and build 100 pcs in each.
