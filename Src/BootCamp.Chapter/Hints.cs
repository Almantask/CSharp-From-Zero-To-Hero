using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Hints
{
    // Leave it empty, because subjects are unrelated. Just for simulation
    // Alternatively use base Subject class.
    public interface ISubject { }

    // For simulation you can store a specific teacher to school.
    // However for the interface based on requirements it is not needed.
    interface ISchool<in TStudentIn, TStudentOut> 
        where TStudentIn : IStudent
        where TStudentOut : IStudent
    {
        // Missing:
        // Add
        // Get
        void AddStudent(TStudentIn student);
        List<TStudentOut> GetStudents();
    }

    public interface IStudent
    {
        long Id { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject;
    }


    public interface ITeacher<TSubject> where TSubject : ISubject
    {
        TSubject ProduceMaterial();
    }
}
