using static BootCamp.Chapter.ITeacher;
using System;

namespace BootCamp.Chapter
{
    interface IStudent
    {
        interface IStudent
        {
            long Id { get; }

            void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
                where TTeacher : ITeacher<TSubject>
                where TSubject : ISubject;
        }
    }
}