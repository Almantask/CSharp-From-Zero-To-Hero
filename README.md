# C#: From Zero To Hero
## Chapter 3: C#. Homework 11: Serialization for JSON and XML
### Intro
Portable data format has been an issue for a long time. We did have binary since the beginning, however
a human simply couldn't get it. Therefore any kind of changes to such a file would require an intervention of a machine.

This all changed with **XML**. The idea of XML is to have something similar to HTML, except a bit more strict.
Base everything with your own custom tags and here you have it- data format.

Later on **JSON** came to town and now in most cases replaces XML, because it's lighter, more concise, faster.

Why do we need all this? Simply because we need to save object's sate. For example a video game has a whole bunch of objects.
Each object has its' own state and if we want to save the state, we will need to save them to a file.
This process is called **serialization**. When we want to load the game- we will parse the serialized data back into objects.
This is called **deserialization**.

### Task
Refer to https://github.com/csinn/CSharp-From-Zero-To-Hero/tree/Chapter3/Homework/9

Implement saving of results using XML and JSON formats. Input is a JSON, no longer a .csv.