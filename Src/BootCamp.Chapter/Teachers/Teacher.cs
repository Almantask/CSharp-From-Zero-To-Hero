using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    public class Teacher : ITeacher<TeachingSubject>
    {
        public TeachingSubject TeachingSubject { get; set; }

        public Teacher(TeachingSubject subject)
        {
            TeachingSubject = subject;
        }

        public TeachingSubject ProduceMaterial()
        {
            Console.WriteLine($"{this.GetType().Name} taught {TeachingSubject.Subject}.");
            return TeachingSubject;
        }
    }
}
