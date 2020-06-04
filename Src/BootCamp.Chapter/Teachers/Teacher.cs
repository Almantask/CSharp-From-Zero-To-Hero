using System;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public class Teacher<TSubject> : ITeacher<TSubject> where TSubject : ISubject
    {
        public string Name { get; }

        public TSubject SubjectTaught { get; }

        public Teacher(string name, TSubject subjectTaught)
        {
            Name = name;
            SubjectTaught = subjectTaught;
        }

        public TSubject ProduceMaterial()
        {
            Console.WriteLine($"Producing material for {SubjectTaught.Title}");
            return SubjectTaught;
        }
    }
}
