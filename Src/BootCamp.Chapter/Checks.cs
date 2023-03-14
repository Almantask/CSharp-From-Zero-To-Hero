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
            Console.Write(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var validString = Console.ReadLine();
            if (string.IsNullOrEmpty(validString))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return validString;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);

            if (!isNumber)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                
                if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                return -1;
            }

            return (float)(weight / Math.Pow(height, 2));
        }

        public static void DisplayDetail(string name, int age, float weight, float height, float bmi)
        {
            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg & his height is {height} cm. The bmi is {bmi}");
        }
    }
}
