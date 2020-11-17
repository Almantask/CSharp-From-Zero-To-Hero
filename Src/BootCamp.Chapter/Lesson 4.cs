using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson_4
    {
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int Number;
            bool success = int.TryParse(input, out Number);

            if (!success)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            return Number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (input == string.Empty || input == null)
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            float Number;
            bool success = float.TryParse(input, System.Globalization.NumberStyles.Float,
    System.Globalization.CultureInfo.InvariantCulture, out Number);

            if (!success)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            return Number;

        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + $"Height cannot be equal or less than zero, but was {height}" + Environment.NewLine + $"Weight cannot be equal or less than zero, but was {weight}");
                return -1;
            }
            float bmi = weight / height / height;
            return bmi;
        }
    }
}
