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
            Console.WriteLine("Please enter your name:");
            var Name = Console.ReadLine();
            Checks.PromptString(Name);

            Console.WriteLine("Please enter your age:");
            var Age = Console.ReadLine();
            Checks.PromptInt(Age);

            Console.WriteLine("Please enter your height(cm):");
            var Height = Console.ReadLine();
            var C_Height = Checks.PromptFloat(Height);
            Console.WriteLine(C_Height);

            Console.WriteLine("Please enter your weight(kg):");
            var Weight = Console.ReadLine();
            var C_Weight = Checks.PromptFloat(Weight);
            Console.WriteLine(C_Weight);

            Checks.CalculateBmi(C_Weight, C_Height);
        }
    }
}
