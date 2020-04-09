using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to refactor the code I made in Lesson 2.
            // Use functions to achieve DRY (as little duplicate code as possible).

            // Name input
            string name = PromptString("Enter your name: ");

            // Surname input
            string surname = PromptString("Enter your surname: ");

            // Age input
            int age = PromptInt("Enter your age: ");

            // Weight input
            float weight = PromptFloat("Enter your weight(in kg): ");

            // Height input
            float height = PromptFloat("Enter your height(in cm): ");

            // BMI calculation
            float bmi = CalculateBMI(weight, (height / 100));

            // User profile output
            PrintUserProfile(name, surname, age, weight, height, bmi);
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return userInput;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message); 
            string userInput = Console.ReadLine();
            int number;

            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            else if (!int.TryParse(userInput, out number))
            {
                Console.Write("\"{0}\" is not a valid number.", userInput);
                return -1;
            }
            return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            float number;

            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }
            else if (!float.TryParse(userInput, out number))
            {
                Console.Write("\"{0}\" is not a valid number.", userInput);
                return -1;
            }
            return number;
        }

        // {Environment.NewLine} is environment independant

        public static float CalculateBMI(float weightKG, float heightMetres)
        {
            bool isValid = true;
            string message = "Failed calculating BMI. Reason:";

            if (weightKG <= 0)
            {
                message += $"{Environment.NewLine}Weight cannot be equal or less than zero, but was {weightKG}.";
                isValid = false;
            }

            if (heightMetres <= 0)
            {
                if (isValid == false)
                {
                    message += $"{Environment.NewLine}Height cannot be less than zero, but was {heightMetres}.";
                }
                else
                {
                    message += $"{Environment.NewLine}Height cannot be equal or less than zero, but was {heightMetres}.";
                    isValid = false;
                }
            }

            Console.WriteLine(message);
            if (isValid == false) return -1;

            float bmi = (weightKG / heightMetres) / heightMetres;
            return bmi;
        }

        public static void PrintUserProfile(string name, string surname, int age, float weight, float height, float bmi)
        {
            Console.WriteLine("{0} is {1} years old, his weight is {2} kg and his height is {3} cm\nBMI: {4}",
                name + " " + surname,
                age,
                weight,
                height,
                string.Format("{0:F1}", bmi)
                );
        }
    }
}
