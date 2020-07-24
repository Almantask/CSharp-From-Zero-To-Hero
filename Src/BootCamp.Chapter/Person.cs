using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    // This should have the following attribute
    [TextTable(1, '=', 'x', '*')]
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Do not change the bellow
        public override string ToString() => $"{Name} - {Age}";
    }
}
