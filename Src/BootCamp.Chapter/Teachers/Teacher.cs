using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    class Teacher<TSubject> : ITeacher<TSubject> where TSubject : ISubject
    {
        public string Name { get; }
        public TSubject SubjectTaught { get; }

        public Teacher(string name, TSubject subjectTaught)
        {
            Name = name;
            SubjectTaught = subjectTaught;
        }

        public TSubject ProduceTeachingMaterial()
        {
            Console.WriteLine($"Producing the teaching material for {SubjectTaught.Name}");
            return SubjectTaught;
        }
    }

}
