using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.SchoolSubjects
{
    abstract class Subject : ISubject
    {
        public string Message;

        public Subject()
        {
            Message = $"I know {this.GetType().Name}";
        }

        public string GetMessage()
        {
            return Message;
        }

        public void ProduceMaterial()
        {
            Console.WriteLine($"I Learnt {this.GetType().Name}.");
        }
    }
}
