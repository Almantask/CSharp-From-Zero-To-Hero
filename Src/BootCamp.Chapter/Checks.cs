using System;
using System.Collections.Generic;
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
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var i = Console.ReadLine();
            var isNumeric = int.TryParse(i, out int number);
            if (String.IsNullOrEmpty(i))
            {
                return 0;
            }
            else if (!isNumeric)
            {
                Console.Write($"\"{i}\" is not a valid number.");
                return -1;
            }
            else if (isNumeric && number == 0)
            {
                Console.Write($"\"{i}\" is not a valid number.");
                return 0;
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var s = Console.ReadLine();
            if (String.IsNullOrEmpty(s))
            {
                Console.Write("Name cannot be empty.");
                return "-";

            }
            else
            {
                return s;
            }
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var f = Console.ReadLine();
            var isNumeric = float.TryParse(f, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out float number);
            if (String.IsNullOrEmpty(f))
            {
                return 0;
            }
            else if (!isNumeric && number != 0)
            {
                Console.Write($"\"{f}\" is not a valid number.");
                return -1;
            }
            else if (!isNumeric)
            {
                Console.Write($"\"{f}\" is not a valid number.");
                return -1;
            }
            else if (isNumeric && number == 0)
            {
                //Console.WriteLine($"\"{f}\" is not a valid number.");
                return 0f;
            }
            return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            else
            {
                return weight / (height * height);
            }
        }
    }
}
