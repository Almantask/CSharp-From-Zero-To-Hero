# CSharp-From-Zero-To-Hero

[![Build Status](https://dev.azure.com/almantusk/From-Zero-To-Hero/_apis/build/status/csinn.CSharp-From-Zero-To-Hero?branchName=master)](https://dev.azure.com/almantusk/From-Zero-To-Hero/_build/latest?definitionId=6&branchName=master)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/a358adf21c2442cd91a4827a50213ff1)](https://www.codacy.com/manual/Almantask/CSharp-From-Zero-To-Hero?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=csinn/CSharp-From-Zero-To-Hero&amp;utm_campaign=Badge_Grade)
  # The vision
"Programming is hard". Yes.But not harder than running a marathon for a person has never run. It's not harder than 
building a house if you never built one. Programming is hard only until you practice it (like any other skill). I would like to invite you to learn programming and C# following this course to practice programming and ignite passion for finding little miracles in code every day 🙂
  
  # Requirements
  Visual Studio Community 2019 or similar with Web Development and desktop development workloads.  

  Patience and persistence  
  Git installed  
  Github account  
  
  # Schedule

  The lessons will take place on Wednessday and Saturday 9 o clock (GMT +2).
  After every lesson the homework will be annnouned and will also be placed in the discord bc-homework channel.
  Also the slides and the video's can be found on the discord channel but then in the bc-material channel. 

  # Homework 
  Homework will be announced at the end of every lesson and placed in this repository base on lesson name. There will be 2 branches after every lesson:  
  ```
  Lesson/LessonName  
  Homework/LessonName  
  ```
  ## Git
  Fork this repository (Homework/LessonName). 
  The fork target is called upstream branch. For every chapter, you will need to keep updating upstream branch. 
  How to work with forked repository in Visual Studio Teams:  
  https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/Github-In-Vs
  
  ## How to complete homework? 
  ### Implementation of homework
  For the first chapters, homework branch will come with 2 projects:
  ```
  ChapterName.csproj
  ChapterName.Tests.csproj
  ```
  For now, a student should not care about about the tests project, as long as it builds. 
  All the student work will happen in **ChapterName.csproj**. 
  You will have empty functions which you will have to implement based on the homework requirements. 
  Student can consider a **homework complete if all tests pass**.
  
  ### Homework submission
 
  In order for mentors to review your homework, you will need to create a Pull Request (PR) 
  How to do it can be found here on point 7: https://github.com/csinn/CSharp-From-Zero-To-Hero/wiki/Github-In-Vs 
  
  ## Homework review
  ### Automatic code reviewer
  To automate standards review, we have a static analysis tool--Codacy. It will grade your code (A- being the highest grade). Homework will not be considered complete, if grade is D or lower. 
  ### Auto build and auto tests
  In order to find out if your code works not just on your machine but in all environments, check the build status. 
  In PR you will see Azure Pipelines and it should have x check passed. 
  Todo: screen shot 

  ### Mentor code review
  In order for your PR to be complete, it needs a code review of at least 2 mentors. 
  Both of the mentors will have to approve your code, otherwise you won't have a PR completed. 
  
  How to do code review:
  As a reviewer- Todo: link
  As a reviewee-Todo: link
  Code reviews on GitHub- Todo: link
  
  ### Finishing homework
  You can consider your homework complete if all of the above steps pass. 
  **Don't merge the PR to master branch**
  A single best homework implementation will be merged to master. 

  

  # Community
  If you want to join as either mentor or pupil or have any questions, please refer to our discord Community.  
  https://discord.gg/rCMKcUU
  
  



 

 

=======
## Chapter 1. Homework 1 and 2
### Intro
#### Variables
Nearly every single program needs variables.
A variable has a name, type and value. They are used to carry some small state (value) throughout the program.
The whole point of variables is to be consumed.
We consume variables by passing them into functions.
#### Visual Studio
IDE is an environment where all the programming is done. 
It offers all the needed tools: 
- Hints while writing code (Intellisence)
- Run code
- Debug code
- Analyse code: see errors, warnings, code complexity...
#### Open source and Github
Open source code is how people all around the world, without knowing each other collaborate.
Such way of collaborating needs to be learned early, if you want to do anything serious with programming.
It's not very easy and intutive to learn it right away.
Some might even consider it hard or too hard.
Regardless of that, it's necessary if we want to ensure easy and convenient collaboration.  

Github is an open source code host. It's the most popular and widely use host for git.
Therefore we will be using it for all of our homework.

### Pull Request
Pull request is means of communicating to the owner of code, that you would like to introduce a change.
It doesn't matter who asks to make a change, all that matters is that changes are relevant and adds value to the repository.  

You will be learning all of the above throughout this homework.

### Hints
* The tasks require you to have already created an account on GitHub. Do that first!
* If you do not understand something or need help:
  * Ask questions in the channel bc-discussion in Discord.
  * Check the wiki of this repository (work in progress!).
  * Check the bc-materials channel for reference material.
  * Check the bc-announcements channel for related stuff.

### Task
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
* Pass all Pull Request checks (mentor review, Codacy review) 

