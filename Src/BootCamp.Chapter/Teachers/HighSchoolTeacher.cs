using System;
using BootCamp.Chapter.Hints;

namespace BootCamp.Chapter.Teachers
{
    public class HighSchoolTeacher: ITeacher<ISubject>
    {
        public ISubject Subject { get; set; }

        public HighSchoolTeacher(ISubject subject)
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
            return nameof(HighSchoolTeacher);
        }
    }
}