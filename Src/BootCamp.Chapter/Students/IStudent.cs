using BootCamp.Chapter.Teachers;
using System;

namespace BootCamp.Chapter
{
    interface IStudent
    {
        public Guid @Guid { get; }
        public string Name { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject;
    }
}