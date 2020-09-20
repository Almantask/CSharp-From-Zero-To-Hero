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
            Lesson3.StringRequests("Enter your first name:  ");
            Lesson3.StringRequests("Enter your Last name: ");

            Lesson3.ageRequests("Enter your age: ");

            Lesson3.BMICalculator(Lesson3.ageRequests("Enter weight: "), Lesson3.BMiRequests("Enter height: "));
        }
    }
}