using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 3; i++)
            {
                var firstName = Checks.PromptString("What is their first/given name?");
                var lastName = Checks.PromptString("What is their last/family name?");
                var age = Checks.PromptInt("What is their age in years?");
                var weightKg = Checks.PromptFloat("What is their weight in kilograms? Enter in decimal format.");
                var heightM = Checks.PromptFloat("What is their height in meters? Enter in decimal format.");
                float bmi = Checks.CalculateBmi(weightKg, heightM);
                Console.WriteLine(
                    String.Format("{0} {1} is {2} {3} old, their weight is {4} kilograms, and their height is {5} meters.",
                                    firstName,
                                    lastName,
                                    age,
                                    PluralizeSimpleSuffix("year", "s", age),
                                    weightKg.ToString("F1", CultureInfo.CurrentCulture),
                                    heightM.ToString("F1", CultureInfo.CurrentCulture)
                    ));
                Console.WriteLine(
                    String.Format(
                        "Their BMI is {0}.",
                        bmi.ToString("F1", CultureInfo.CurrentCulture)
                ));
                Console.WriteLine("----");
            }
        }

        private static string PluralizeSimpleSuffix(string word, string suffix, int count)
        {
            if (count == 1)
            {
                return word;
            }
            else
            {
                return word + suffix;
            }
        }
    }
}
