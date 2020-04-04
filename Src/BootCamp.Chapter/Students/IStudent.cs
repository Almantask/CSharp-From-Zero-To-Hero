using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;
using System.Collections.Generic;

namespace BootCamp.Chapter.Students
{
    interface IStudent
    {
        // has a list of materials learnt.
        long Id { get; }

        //List<ISubject> learntSubjects;

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher) where TTeacher : ITeacher<TSubject> where TSubject : ISubject;
    }
}
