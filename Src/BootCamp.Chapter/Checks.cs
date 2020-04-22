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
        public const int InvalidInt = -1;
        public const float InvalidFloat = -1;
        public const string InvalidString = "-";
        public const string myStrQuote = "\"";

        public static int PromptInt(string message)
        {   
            Console.WriteLine(message);
            string intString = Console.ReadLine();
            if (string.IsNullOrEmpty(intString)) return 0;

           bool isValidInt = int.TryParse(intString, out int ValidInt);
            if (!isValidInt || ValidInt < 0)
            {
                Console.Write(myStrQuote + intString + myStrQuote + " is not a valid number.");
                return InvalidInt;
            }
            
            return ValidInt;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string validString = Console.ReadLine();

            if (string.IsNullOrEmpty(validString))
            {
                Console.Write("Name cannot be empty.");
                return InvalidString;
            }

            return validString;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string floatString = Console.ReadLine();
            if (string.IsNullOrEmpty(floatString)) return 0;

            bool isValidFloat = float.TryParse(floatString, out var validFloat);
            if (!isValidFloat)
            {
                Console.Write(myStrQuote + floatString + myStrQuote + " is not a valid number.");
                return InvalidFloat;
            }

            return validFloat;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
            }
            else if (height <= 0 && weight > 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else if (height > 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
            float heightInMetersSquared = height;
            heightInMetersSquared *= heightInMetersSquared;
            var bodyMassIndex = weight / heightInMetersSquared;
            return bodyMassIndex;
        }
    }
}
