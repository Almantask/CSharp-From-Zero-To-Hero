using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            var firstName = Checks.PromptString("What is their first name?");
            var lastName = Checks.PromptString("What is their last name?");
            var age = Checks.PromptInt("What is their age in years?");
            var weightKg = Checks.PromptFloat("What is their weight in kilograms?");
            var heightM = Checks.PromptFloat("What is their height in meters?");
            float bmi = Checks.CalculateBmi(weightKg, heightM);
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
    }
}
