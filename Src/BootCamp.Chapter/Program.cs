using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note to self: you need name, surname, age, weight, height and BMI
            PrintInput(attribute: "name");
            PrintInput(attribute: "surname");
            PrintInput(attribute: "age");
            PrintInput(attribute: "weight");
            PrintInput(attribute: "height");
        }

        private static void PrintInput(string attribute)
        {
            Console.Write("What is your " + attribute + "?");
            var input = Console.ReadLine();
        }
    }
}
