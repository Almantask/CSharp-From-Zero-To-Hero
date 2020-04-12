using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        internal static void Demo()
        {
            // Greetings
            Console.WriteLine("Hello! Im a BMI Calculator, to calculate I need some info.");

            // Get Info from user
            string name = PromptString("First name: ");
            string surname = PromptString("Surname: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight(Kg): ");
            float height = PromptFloat("Height(cm): ");

            // Convert height(Cm) to Metres
            float heightM = height / 100;

            // Calculate BMI
            float bmi = CalculateBmi(weight, heightM);

            // Print Info on console
            Console.WriteLine($"{name} {surname} is {age} year old, his weight is {weight} kg and his height is {height} cm.\n" +
                    $"BMI: {bmi}");

            // Ask if user want to do the test again
            Console.WriteLine("Would you like to try again?");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes" || response.ToLower() == "y")
            {
                Console.Clear();
                Demo();
            }
        }

        public static float CalculateBmi(float weight, float height)
        {
            // Check if either height or weight is less or equall to zero
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (weight <= 0) {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                if (weight <= 0 && height <= 0)
                {
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                }
                else if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }

                return -1;
            }
            else
            {
                float bmi = weight / (height * height);
                return bmi;
            }
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            if (string.IsNullOrEmpty(value)) return 0;
            
            bool isFloat = float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out float floatNumber);
            if (!isFloat) return NotANumber(value);

            return floatNumber;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();

            if (string.IsNullOrEmpty(value)) return 0;

            bool isInt = int.TryParse(value, out var intNumber);
            if (!isInt) return NotANumber(value);
            return intNumber;
        }
        
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string value =  Console.ReadLine();

            if (string.IsNullOrEmpty(value))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return value;
        }

        private static int NotANumber(string value)
        {
            Console.Write($"\"{value}\" is not a valid number.");
            return -1;
        }

    }
}