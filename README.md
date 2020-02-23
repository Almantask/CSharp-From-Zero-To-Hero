# C#: From Zero To Hero
## Chapter 1. Homework 10: Random and mod

### Intro
#### Random
Randomization is great when we need to generate a sequence of number or make a simulation, especially of a game.
Random class is what enables that in C#. We can generate random numbers (of different types), even random bytes.
This means that with random, we can randomize pretty much everything.

#### Mod
Mod is an operation, which divides a number and takes the remainder part.
In C#, it's done using ``%``. For example ``5%2 = 1``, ``4%2 = 0``.
Mod is especially useful for rotating values within array (starting over) and an example of such application is Caesar Cipher.

### Task

1) Generate random text
2) Implement Caesar cipher:  
https://en.wikipedia.org/wiki/Caesar_cipher  
It needs to support both encryption and decryption  
Create 2 functions:  
```
string Encrypt(string message, byte shift)
string Decrypt(string message, byte shift)
```
The cipher should support all the ASCII symbols.
