using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter.Students
{
    public abstract class StudentBase : IStudent
    {
        public long Id { get; }

        public StudentBase(long id)
        {
            Id = id;
        }

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher) where TTeacher : ITeacher<TSubject> where TSubject : ISubject
        {
            Console.WriteLine($"Learning from {teacher.Name} about {teacher.produceMetarial().Name}");
        }
    }
}
