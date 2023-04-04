using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter.Teachers
{
    public class MiddleSchoolTeacher: ITeacher<ISubject>
    {
        public ISubject Subject { get; set; }

        public MiddleSchoolTeacher(ISubject subject)
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
            return nameof(MiddleSchoolTeacher);
        }
    }
}