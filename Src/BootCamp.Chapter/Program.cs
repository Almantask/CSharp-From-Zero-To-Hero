using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Lesson3.Demo();
            Lesson3.ReadString("Enter your first name:  ");
            Lesson3.ReadString("Enter your Last name: ");

            Lesson3.ParseAge("Enter your age: ");

            Lesson3.CalculateBMI(Lesson3.ParseBmi("Enter weight: "), Lesson3.ParseBmi("Enter height: "));
        }
    }
}