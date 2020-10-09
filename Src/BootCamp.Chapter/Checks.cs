using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Globalization;

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
        static CultureInfo invC = CultureInfo.InvariantCulture;
        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            if(!isNumber || number <= 0)
            {
                Console.WriteLine("\"" + input + "\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, NumberStyles.Float, invC, out float number);
            if (!isNumber || number <= 0)
            {
                Console.WriteLine("\"" + input + "\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if(height <= 0 || weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (height <= 0)
                {
                    Console.Write("Height cannot be equal or less than zero, but was " + height + ".");
                }
                if(weight <= 0)
                {
                    Console.Write("Weight cannot be equal or less than zero, but was " + weight + ".");
                }
                Console.WriteLine();
                return -1;
            }

            return weight / (height * height);
        }
    }
}
