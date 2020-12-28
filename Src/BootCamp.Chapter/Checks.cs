
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
        public const int IntegerError = -1;
        public const string StringError = "-";
        public const float FloatError = -1.0f;

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int variable;
            bool num = int.TryParse(input, out variable);
            
            if (!num)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return IntegerError;
            }
            return variable;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            if (name == string.Empty || name == null)
            { 
                Console.WriteLine("Name cannot be empty.");
                return StringError;
            }
            return name;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            float variable;
            bool num = float.TryParse(input, NumberStyles.Float,CultureInfo.InvariantCulture, out variable);
            if (!num)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return FloatError;
            }
            return variable;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if(weight <= 0|| height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + $"Height cannot be equal or less than zero, but was {height}" + Environment.NewLine + $"Weight cannot be equal or less than zero, but was {weight}");
                return -1;
            }

            float Bmi;
            Bmi = weight / height / height;
            return Bmi;
        }
    }
}


