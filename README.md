# C#: From Zero To Hero
## Chapter 3: C#. Homework 10: Attributes
### Intro
Attributes are simply flags to indicate that something will be done, when object, decorated
with attributes will pass a certain spot. Sometimes the logic is simply better suited elsewhere, at the 
same time it can be universally applied to multiple code elements.

### Task
Implement TextBoxPrinter class that can Print(object). Print wraps the object .ToString() returned text with a given symbol and a given padding (sides (top and left) and corner symbols are known).

Symbols and paddings come from custom attributes that are applied to a class. [TextTable(padding, sideTop, sideLeft, corner]. If no attribute is supplied, it will just print ToString() returned from that object.
For example:  
[Textable(0, '-', '|', '+']  
           +-----+  
           |Hello|  
           +-----+  

[TextTable(1, '=', 'x', '*')]  
           \*\=\=\=\=\=\=\=\*  
           x       x  
           x Hello x  
           x       x  
           \*\=\=\=\=\=\=\=\*  