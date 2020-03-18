using System;
using System.Collections.Generic;
using System.Text;
// ReSharper disable All

namespace BootCamp.Chapter.Examples.NullCoalecingDemo
{
    public enum Gender
    {
        M,
        F,
        O
    }

    public class Person1
    {
        public string Name { get; }
        public int Weight { get; }

        public Person1(string name, int weight)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            Weight = weight;
        }
    }

    public class Person2
    {
        public string Name { get; }
        public int Weight { get; }
        public int Age { get; }

        public Person2(string name, int weight, int age = 1)
        {
            Name = name ?? throw new ArgumentNullException("name");
            Weight = weight;
            Age = age;
        }
    }
}
