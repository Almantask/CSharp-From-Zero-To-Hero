using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Hints
{
    // Leave it empty, because subjects are unrelated. Just for simulation
    // Alternatively use base Subject class.
    interface ISubject { }

    // For simulation you can store a specific teacher to school.
    // However for the interface based on requirements it is not needed.
    interface TSchool<TStudent> where TStudent : IStudent
    {
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
}
