using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = PromptString($"Enter name: ");
            int age = PromptInt($"Enter age: ");
            float weight = PromptFloat($"Enter weight (kg): ");
            float height = PromptFloat($"Enter height (m): ");

            Console.WriteLine($"{Environment.NewLine}{name} is {age} years old. Their weight is {weight}kg and height is {height}m.");
            Console.WriteLine($"{name}'s BMI is {CalculateBMI(weight, height)}.{Environment.NewLine}");

            Console.ReadKey();
        }

        public static float CalculateBMI(float weightInKg, float heightInM)
        {
            if (weightInKg <= 0 || heightInM <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (heightInM <= 0 && weightInKg <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightInKg}.");
                    Console.WriteLine($"Height cannot be less than zero, but was {heightInM}.");
                }
                else if (heightInM <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {heightInM}.");
                }
                else if (weightInKg <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightInKg}.");
                }
                return -1;
            }
            return weightInKg / (heightInM * heightInM);
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int processedInput;
            if (!int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out processedInput))
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return processedInput;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write($"Name cannot be empty.");
                input = "-";
            }

            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            float processedInput;
            if (!float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out processedInput))
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            
            return processedInput;
        }
    }
}
