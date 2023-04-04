using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter.Teachers
{
    public class UniversityTeacher : ITeacher<ISubject>
    {
        public ISubject Subject { get; }

        public UniversityTeacher(ISubject subject)
        {
            Subject = subject;
        }
        
        public ISubject ProduceMaterial()
        {
            Console.WriteLine($"Producing {Subject} material.");
            return Subject;
        }

        public override string ToString()
        {
            return nameof(UniversityTeacher);
        }
    }
}