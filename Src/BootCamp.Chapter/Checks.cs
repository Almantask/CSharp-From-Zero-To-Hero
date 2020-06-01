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
            int number;
            var input = Console.ReadLine();
            var numberCheck = int.TryParse(input, out number);
            if (!numberCheck)
            {
                Console.WriteLine(input + " is not a valid number");
                return -1;
            }

            if (int.Parse(input) == 0)
            {
                return 0;
            }
            if (numberCheck)
            {
                return int.Parse(input);
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            String input = Console.ReadLine();
            var stringCheck = string.IsNullOrEmpty(input);
            if (stringCheck)
            {
                Console.WriteLine("name cannot be empty");
                return "-";
            }
            else
            {
                return input;
            }

        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            float number;
            var floatCheck = float.TryParse(input, out number);
            if (!floatCheck)
            {
                Console.WriteLine(number);
                Console.WriteLine(input + " is not a valid number");
                return -1;
            }
            if (float.Parse(input) == 0)
            {
                return 0;
            }
            if (floatCheck)
            {
                return float.Parse(input);
            }

            return number;
        }
        public static void printError(string y, float x)
        {

            Console.WriteLine("Failed calculating BMI. Reason: " + y + " cannot be equal or less than zero, but was " + x);

        }
        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 && height <= 0)
            {
                printError("Weight", weight);
                printError("Height", height);
                return -1;
            }
            else if (weight <= 0)
            {
                printError("Weight", weight);
                return -1;
            }
            else if (height <= 0)
            {
                printError("Height", height);
                return -1;
            }
            else
            {
                return weight / (height * height);
            }


        }
    }
}