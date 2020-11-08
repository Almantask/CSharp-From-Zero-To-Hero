using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
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
