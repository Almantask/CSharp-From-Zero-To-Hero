using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter;

namespace BootCamp.Chapter.Hints
{
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
            where TTeacher : Teacher<TSubject> 
            where TSubject : Subject, new();
    }


    interface ITeacher< TSubject> where TSubject : Subject
    {
        TSubject ProduceMaterial();
    }
}
