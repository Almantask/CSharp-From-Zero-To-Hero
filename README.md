# C#: From Zero To Hero
Chapter 3: C#. Homework 2: struct, in, ref, out
```
Create an insecure credentials manager, which works supports register and login functions. 

Register works like this:
1) User inputs name and password
2) Password gets encoded to Unicode
3) Username (not encodd) and password (encoded) are persisted in a file

Login works like this:
1) Reads the credentials file
2) User inputs their credentials
3) Encodes password
4) Encoded password is searched for in credentials field
5) Comparison between encoded passwords is made
6) Is password, login returns true, else returns false.

Extra #1: credentials parsing from the file should be done applying TryParse pattern. 
Extra #2: inputting password should be hidden with smile emoji character.
```