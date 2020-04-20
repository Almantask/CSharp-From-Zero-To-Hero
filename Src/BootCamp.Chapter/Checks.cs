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
            var input = Console.ReadLine();
            bool isValidAge = string.IsNullOrEmpty(input);
            if (isValidAge) return 0;
            isValidAge = int.TryParse(input, out int age);
            if (!isValidAge || age < 0)
            {
            Console.Write($"{(char)34}{input}{(char)34} is not a valid number.");
            return -1;
            }
            return age;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string promptname = Console.ReadLine();
            bool isValidName = string.IsNullOrEmpty(promptname);
            if (isValidName)
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return promptname;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) return 0;
            var isFloat = int.TryParse(input, out var promptInfo);
            if (!isFloat) Console.WriteLine($"{input} is not a valid number.");
            return promptInfo;
        }

        public static float CalculateBmi(float weightkg, float heightcm)
        {
            if (weightkg <= 0 && heightcm <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + $"Weight cannot be equal or less than zero, but was {weightkg}.");
                Console.WriteLine($"Height cannot be less than zero, but was {heightcm}.");
            }
            else if (heightcm > 0 && weightkg <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + $"Weight cannot be equal or less than zero, but was {weightkg}.");
            }
            else if (weightkg > 0 && heightcm <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + $"Height cannot be equal or less than zero, but was {heightcm}.");
            }

            float heightm = heightcm / 100.0f;
            float bmi = weightkg / (heightm * heightm);

            return bmi;
        }
    }
}
