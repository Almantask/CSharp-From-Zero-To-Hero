# C#: From Zero To Hero
## Chapter 3: C#. Homework 4: Generics and covariance/contravariance
### Intro
C# is a brilliant language and one of the nicest features that it has involves generics.
Types or methods can be generic. 
It's important to understand that generic is similar to polymorphism. They are similar, because
different types can be interacted through the same method. There is one key difference:  
**Generics** have a **single method** which accepts multiple types
**Polymorphism** has many methods which are derived from the same type. Therefore it has **multiple implementations**.

One of a more complex topics in OOP is the slightly abnormal behaviour of generics generalization.
You cannot generalize generics by default.  
A generic **covariance**- means that generic type is able to retain its' original form- it can be generalized.
This can be done by *applying out for T which is an output*.  
There is the opposite of covariance- **contravariance**. And here is the anomoly- instead of generalizing generic-
you can specify it instead without any casts. *This can be specified with in keyword and works for T that is input*. 
It works like this, because a generic type which takes a more generalized T can accept a more specialized T as well.

### Task
Illustrate generic covariance and contravariance using the following example:  
There are different kinds of students:  
- HighSchool Student  
- University Student    
And different kinds of schools:  
- Middle School  
- High School  
- Univeristy  
And different kinds of teachers:    
- High School Teacher  
- Middle School Teacher  
- University Teacher  
And different kinds of subjects (and material for each subject):  
- Maths  
- Art  
- Music  
- PE  
- English  
- Programming  

You are told to implement a simulation where:  
- Students can learn from **any teacher** (by consuming the material a teacher produced)  
- Specific teachers produce material for a specific subject  
- Specific schools have ability to add or get specific students  

Implementing this simulation should use the following interfaces with the right in/out modifiers and constraints for each generic T:
```
    // Leave it empty, because subjects are unrelated. Just for simulation
    // Alternatively use base Subject class.
    interface ISubject { }

    // For simulation you can store a specific teacher to school.
    // However for the interface based on requirements it is not needed.
    interface ISchool<TStudent> where TStudent : IStudent
    {
        // Missing:
        // Add
        // Get
    }

    interface IStudent
    {
        long Id { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject;
    }


    interface ITeacher<TSubject> where TSubject : ISubject
    {
        TSubject ProduceMaterial();
    }
```
