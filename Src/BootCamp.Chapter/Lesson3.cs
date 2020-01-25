using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            var doAnotherPerson = true;
            while (doAnotherPerson)
            {
                var firstName = PromptString("First Name: ");
                var surname = PromptString("\nSurname: ");
                var age = PromptInt("\nAge: ");
                var weight = PromptFloat("\nWeight in kilograms: ");
                var height = PromptFloat("\nHeight in meters: ");
                var bmi = CalculateBmi(weight, height);

                Console.WriteLine($"{firstName} {surname} is {age} years old, his weight is {weight} kg and his height is {height} meters.\n" +
                    $"Body-mass index (BMI) is: {bmi.ToString("0.00")}");

                var answer = PromptString("\nDo you want to check BMI for another person? y/n: ").ToLowerInvariant();
                doAnotherPerson = answer.Equals("y") || answer.Equals("yes");
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static string PromptString(string message)
        {
            var userInput = GetUserInput(message);
            
            if (string.IsNullOrEmpty(userInput))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return userInput;
        }

        public static int PromptInt(string message)
        {
            var userInput = GetUserInput(message);

            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }

            bool isNotValidInt = !Int32.TryParse(userInput, out int number);
            if (isNotValidInt)
            {
                Console.Write($"\"{userInput}\" is not a valid number.");
                return -1;
            }
            return number;
        }
        public static float PromptFloat(string message)
        {
            var userInput = GetUserInput(message);

            if (string.IsNullOrEmpty(userInput))
            {
                return 0f;
            }

            bool isNotValidFloat = !float.TryParse(userInput, out float number);
            if (isNotValidFloat)
            {
                Console.Write($"\"{userInput}\" is not a valid number.");
                return -1;
            }
            return number;
        }
        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                return -1;
            }
            if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }

            if(height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return -1;
            }

            if(weight == height)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be more or equal to height.");
                Console.WriteLine($" Height= {height}, Weight= {weight}.");
                return -1;
            }

            return weight / height / height;
        }

        public static bool ValidInputForBmi(float number)
        {
            return number <= 0;
        }
    }
}
