using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Employee_NullObject
{
    public class Person
    {
        public string Name { get; }

        public Employment Employment { get; set; }

        public Person(string name, Employment employment)
        {
            Name = name;
            Employment = employment;
        }

        public Person(string name)
        {
            Name = name;
            Employment = new Unemployed();
        }
    }
}
