using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            var firstName = PromptString("What is their first name?");
            var lastName = PromptString("What is their last name?");
            var age = PromptInt("What is their age in years?");
            var weightKg = PromptFloat("What is their weight in kilograms?");
            var heightM = PromptFloat("What is their height in meters?");
            float bmi = CalculateBmi(weightKg, heightM);
            Console.WriteLine(
                String.Format("{0} {1} is {2} {3} old, their weight is {4} kilograms, and their height is {5} meters.",
                                firstName,
                                lastName,
                                age,
                                Pluralize("year", age, "s"),
                                weightKg.ToString("F1", CultureInfo.CurrentCulture),
                                heightM.ToString("F1", CultureInfo.CurrentCulture)
                ));
            Console.WriteLine(
                String.Format(
                    "Their BMI is {0}.",
                    bmi.ToString("F1", CultureInfo.CurrentCulture)
            ));
        }

        private static string Pluralize(string word, int count, string suffix)
        {
            if (count == 1)
            {
                return word;
            } else
            {
                return word + suffix;
            }
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float number = 0.0f;
            bool convertedSuccessfully = false;
            while (!convertedSuccessfully)
            {
                convertedSuccessfully = float.TryParse(
                    Console.ReadLine(),
                    NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out number
                );
                if (!convertedSuccessfully)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            return number;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int number = 0;
            bool convertedSuccessfully = false;
            while (!convertedSuccessfully)
            {
                convertedSuccessfully = Int32.TryParse(Console.ReadLine(), out number);
                if (!convertedSuccessfully)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            return weightKg / (heightM * heightM);
        }

    }
}
