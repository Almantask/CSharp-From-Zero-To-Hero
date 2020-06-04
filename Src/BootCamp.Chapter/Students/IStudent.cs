using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;
using System;

namespace BootCamp.Chapter.Students
{
    public interface IStudent
    {
        string Name { get; }
        Guid guid { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject;
    }
}
