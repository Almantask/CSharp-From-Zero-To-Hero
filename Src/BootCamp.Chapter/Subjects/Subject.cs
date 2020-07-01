using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Subjects
{
    class Subject : ISubject
    {
        public string Name { get; }

        public string Description { get; }

        public Subject(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
