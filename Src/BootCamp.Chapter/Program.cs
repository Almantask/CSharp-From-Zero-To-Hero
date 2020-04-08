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

            Lesson3.Demo();

            Lesson3.Bmi(150, 1075);
            Console.WriteLine(Bmi);

            Lesson3.Numbers();

            Lesson3.Colors();

            Lesson3.Balloon();
        }
    }
}
