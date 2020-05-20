using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Dummies
{
    public class Person
    {
        public string Name { get; }
        public DateTime? Birthday { get; }

        public Person(string name, DateTime? birthday = null)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
