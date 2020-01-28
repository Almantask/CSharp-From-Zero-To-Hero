using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal static class InteractionsManager
    {
        public static bool ContinueRunningProgram { get; private set; } = true;
        public static void PerformInteractions()
        {
            var name = Prompter("What is your full name?");
            var age = int.Parse(Prompter("What is your age?"));
            var weight = double.Parse(Prompter("What is your weight in kg?"));
            var height = double.Parse(Prompter("What is your height in cm?"));
            var bmi = CalculateBmi(height, weight);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"{name} has a BMI of {bmi}");
            Console.WriteLine();

            var response = Prompter("Would you like to run the program again? (y/n)");
            ContinueRunningProgram = response.Equals("y", StringComparison.InvariantCultureIgnoreCase);
        }

        private static string Prompter(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static double CalculateBmi(double height, double weight)
        {
            if (weight > 0 && height > 0)
            {
                var heightInMeters = height / 100;
                return weight / (heightInMeters * heightInMeters);
            }

            return 0;
        }
    }
}
