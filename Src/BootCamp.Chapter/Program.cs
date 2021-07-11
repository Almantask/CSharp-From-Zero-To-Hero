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
            
            Checks.PromptString();
            Checks.PromptInt();
            Console.WriteLine("Please enter your height(cm):");
            var height = Console.ReadLine();
            var cHeight = Checks.PromptFloat(height);
            Console.WriteLine("Please enter your weight(km):");
            var weight = Console.ReadLine();
            var cWeight = Checks.PromptFloat(weight);

            Checks.CalculateBmi(cWeight, cHeight);
        }
    }
}
