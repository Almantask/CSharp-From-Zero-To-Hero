using System;
using System.Collections.Generic;
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
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int result;
            bool isNumber = int.TryParse(input, out result);
            if (!isNumber) return -1;
            return result;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            if (name == string.Empty) return "-";
            return name;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            float f = float.Parse(input, CultureInfo.InvariantCulture);
            return f;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if(weight <= 0|| height <= 0)
            {
                Console.WriteLine("Failed calculating BMI.Reason:" + Environment.NewLine + $"Height cannot be equal or less than zero, but was {height}" + Environment.NewLine + $"Weight cannot be equal or less than zero, but was {weight}");
                return -1;
            }
            float bmi = weight / height / height;
            return bmi;
        }
    }
}
