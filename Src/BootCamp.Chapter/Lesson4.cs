using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = PromptString($"{Environment.NewLine}Enter name: ");
            int age = PromptInt($"{Environment.NewLine}Enter age: ");
            float weight = PromptFloat($"{Environment.NewLine}Enter weight (kg): ");
            float height = PromptFloat($"{Environment.NewLine}Enter height (m): ");

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
            Console.Write(message);
            string input = Console.ReadLine();

            int processedInput;
            if (!int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out processedInput))
            {
                Console.Write($"{Environment.NewLine}\"{input}\" is not a valid number.");
                return -1;
            }

            if (processedInput <= 0)
            {
                return 0;
            }
            return processedInput;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.Write($"{Environment.NewLine}Name cannot be empty.");
                input = "-";
            }

            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input == "")
            {
                return 0;
            }

            float processedInput;
            if (!float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out processedInput))
            {
                Console.Write($"{Environment.NewLine}\"{input}\" is not a valid number.");
                return -1;
            }
            
            return processedInput;
        }
    }
}
