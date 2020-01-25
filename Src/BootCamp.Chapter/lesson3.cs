// This file is for hunting bugs only.
// Completing homework 3 before looking at this is HIGHLY recommended.
// Try to look at the code in GitHub first. Try to find the mistakes that
// were made without help or tools first.
// After that try to find every single thing that seems off.
// Have fun! :)
using System;
using System.Globalization;
using static System.Console;

namespace BootCamp.Chapter
{
    internal static class Lesson3
    {
        public static void Demo(int iterations)
        {
            int count = 0;
            do
            {
                ProcPrsn();
                count++;
            } while (count < iterations);
        }

        private static void ProcPrsn()
        {
            string name = PromptString("What's ya name, mate?");

            float weight = AsFloat("What is your weight?");

            float heigth = AsFloat("What is your heigth?");

            int age = ReadMyInput("And your age?");
            WriteLine($"{name} - {age} years old");
            CalcBMI(weight, heigth);
        }

        public static int ReadMyInput(string message)
        {
            WriteLine(message);
            var input = ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                WriteLine("Invalid!");
                return -1;
            }
            else
            {
                return int.Parse(input);
            }
        }

        public static string PromptString(string message)
        {
            WriteLine(message);

            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                WriteLine("Invalid!");
                return "Invalid";
            }
            else
            {
                return input;
            }
        }

        public static float AsFloat(string message)
        {
            WriteLine(message);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                WriteLine("Invalid!");
                return -1;
            }
            else
            {
                return float.Parse(input, CultureInfo.InvariantCulture);
            }
        }

        public static float CalcBmi(float weight, float heigth)
        {
            const int maxBmi = 40;
            var bmi = weight / (float)Math.Round(Math.Pow(heigth, 2), 2);

            WriteLine($"Your BMI is: {bmi}");

            if (bmi > maxBmi)
            {
                WriteLine("You really shouldn't eat that much cake!");
                WriteLine("No offense, mate.");
            }
            return bmi;
        }
    }
}