using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            ProcessPersonBMI(); 
            Pause();
            ProcessPersonBMI(); 
            Pause();
        }
        public static void ProcessPersonBMI()
        {
            //Get input from the user.
            string firstName = GetStringInput("Enter your first name: ");
            string lastName = GetStringInput("Enter your last name: ");
            int age = GetIntInput("Enter your age: ");
            float weight = GetFloatInput("Enter your weight (in kg): ");
            float height = GetFloatInput("Enter your height (in M): ");
            float bmi = CalculateBMI(weight, height);

            //Print back information and follow up with BMI calculation.
            PrintBMI(firstName, lastName, age, weight, height, bmi);
        }
        public static void PrintBMI(string firstName, string lastName, int age, float weight, float height, float bmi)
        {
            Console.WriteLine($"{firstName} {lastName} is {age} years old, weighs {weight} kg and is {height} M tall.");
            Console.Write($"BMI calculated as {bmi:0.00}"); //Format BMI to 2 decimal places for readability.
        }
        public static float CalculateBMI(float weight, float height)
        {
            if (weight <= 0f || height <= 0f)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0f && height <= 0f)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                    return -1f;
                }
                if (weight <= 0f)
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                if (height <= 0f)
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");

                return -1f;
            }
            
            var bmi = weight / (height * height);
            return bmi;
        }
        public static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                input = "-";
            }

            return input;
        }
        public static int GetIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            bool isNumber = int.TryParse(input, out int number);

            if ((isNumber && number <= 0) || string.IsNullOrEmpty(input))
                return 0;
            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }
        public static float GetFloatInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            bool isFloat = float.TryParse(input, out float number);

            if ((isFloat && number < 0f) || string.IsNullOrEmpty(input))
                return 0f;
            if (!isFloat)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1f;
            }

            return number;
        }
        public static void Pause()
        {
            //Pause program so output can be read by user.
            Console.ReadKey();
            Console.Clear();
        }
    }
}
