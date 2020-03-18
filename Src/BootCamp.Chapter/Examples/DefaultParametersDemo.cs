using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.NullCoalecingDemo;

namespace BootCamp.Chapter.Examples
{
    public static class DefaultParametersDemo
    {
        public static void Run()
        {
            // age = 0
            var person1 = new Person2("Tom", 2);
            // age = 0
            var person2 = new Person2("Tom", 2, 1);

            Console.WriteLine($"Two people of ages: {person1.Age}, {person2.Age}.");
        }

    }
}
