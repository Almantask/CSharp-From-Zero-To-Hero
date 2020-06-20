using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo();

            Console.Write(CalculateBMI(-100, 50));
        }

        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = StringPrompt("Please introduce a name:");
                string surname = StringPrompt("Please introduce surname:");
                int age = IntPrompt("Please introduce age:");
                float weight = FloatPrompt("Please introduce weight (kg):");
                float height = FloatPrompt("Please introduce height (m):");

                Console.WriteLine(PromptPersonData(name, surname, age, weight, height));

                Console.WriteLine(PromptPersonBMI(name, surname, weight, height));

                if (i == 0)
                {
                    Console.WriteLine("Now let's do it a second time!");
                }
            }
        }

        private static string PromptPersonData(string name, string surname, int age, float weight, float height)
        {
            return $"{name} {surname} is {age} years old, weight is {weight} kg and height is {height} m.";
        }

        public static string PromptPersonBMI(string name, string surname, float weight, float height)
        {
            return $"BMI of {name} {surname} is {CalculateBMI(weight, height)}.";
        }

        public static float FloatPrompt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float number))
            {
                return number;
            }
            else if (input == null || input?.Length == 0)
            {
                return 0;
            }
            else
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

        }

        public static string StringPrompt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (input == null || input.Length == 0)
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            else
            {
                return input;
            }
        }

        public static int IntPrompt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            if (input == null || input.Length == 0)
            {
                return 0;
            }
            else
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

        }

        public static float CalculateBMI(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                string errorMessage = $"Failed calculating BMI. Reason:";
                if (weight <= 0)
                {
                    errorMessage += $"{Environment.NewLine}Weight cannot be equal or less than zero, but was {weight}.";
                }
                if (height <= 0)
                {
                    errorMessage += $"{Environment.NewLine}Height cannot be equal or less than zero, but was {height}.";
                }
                Console.WriteLine(errorMessage);
                return -1;
            }
            else
            {
                return weight / (height * height);
            }
        }
    }

}
