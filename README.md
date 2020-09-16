# C#: From Zero To Hero

## Chapter 1. Homework 1 and 2: Variables, Visual Studio, Git and Github

### Intro

#### Variables

Nearly every single program needs variables.
A variable has a name, type and value. They are used to carry some small state (value) throug some part of the program.
The whole point of variables is to be consumed.
We consume variables by passing them into functions or doing arithmetic operations.

#### Finding missing pieces (Console)

Often, a lesson won't cover 100% of material needed for finishing homework. But this is a representation of real life, where you constantly have to get the missing pieces (most likely through googling). The missing pieces in this homework are:

``Console.ReadLine``
``int.Parse``
``double.Parse``. 

#### Visual Studio

IDE is an environment where all the programming is done. 
It offers all the needed tools: 
- Hints while writing code (Intellisence)
- Run code
- Debug code
- Analyse code: see errors, warnings, code complexity...
Visual Studio is probably the best IDE for developing C# code, because it has everything you need out of the box.
Visual Studio Code is another IDE that we could use for C#, though it's much more general and you will need to configure it before you can use it.

#### Open source and Github

Open source code is how people all around the world, without knowing each, other collaborate.
Such way of collaborating needs to be learned early, if you want to do anything serious with programming.
It's not very easy and intutive to learn right away.
Regardless of that, it's necessary if we want to ensure easy and convenient collaboration.  

Github is an open source code host. It's the most popular and widely use host for git.
Therefore we will be using it for all of our homework.

### Pull Request

Pull request allows requesting a change for an open source project.
It doesn't matter who asks to make a change, all that matters is that changes are relevant and adds value to the repository.  

You will be learning all of the above throughout this homework.

### Task

#### Code

Read name, surename, age, weight (in kg) and height (in cm) **from console**. DO NOT HARDCODE (not int age = 5 etc).
1) Print all the info based on the example message below:  

```Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.```

2) Calculate and print body-mass index (BMI)  
3) Do it for 2 people (repeat the same thing twice)

#### Github

Full guide of how to use Visual Studio teams can be found here: https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/Github-In-Vs

* Fork https://github.com/csinn/CSharp-From-Zero-To-Hero/tree/Chapter1/Homework/1And2
  * Open the link.
  * Click the fork button in the upper right.
  * Click the green Clone or download button and clone your repository the way that suits you best.
  * Open your repository in Visual Studio 2019.
  * Select the right branch in the bottom right! That name should be Chapter1/Homework/1And2 instead of master in the end.
  * Make sure that you open Bootcamp.sln. This is called a solution. Remember this!
* Source code from lesson 1 homework should end up on your forked branch.
  * Open the Src folder.
  * Open the BootCamp.Chapter project file. Remember that this is a project file!
  * Open the Program.cs file.
  * Put your code from homework 1 here.
* Create a pull request to request your forked branch to be merged to the source branch.
  * Click the pencil symbol in the bottom right and type in a commit message.
  * Press commit button.
  * Click the single arrow button (next to the pencil) in the bottom right.
  * Push your commit.
  * Click the line plus arrow button (next to the single arrow) in the bottom right.
  * Click create new element.
  * Click on master branch and change it to Chapter1/Homework/1And2.
  * Give your pull request a meaningful title and description.
  * Click create.
* Pass all Pull Request checks (mentor review) 

### Hints

* The tasks require you to have already created an account on GitHub. Do that first!
* If you do not understand something or need help:
  * Ask questions in the channel bc-discussion in Discord.
  * Check the wiki of this repository (work in progress!).
  * Check the bc-materials channel for reference material.
  * Check the bc-announcements channel for related stuff.
