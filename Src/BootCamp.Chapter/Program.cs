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
            string name = PromptUserInput("Enter your name: ");

            // Surname input
            string surname = PromptUserInput("Enter your surname: ");

            // Age input
            int age = ConvertStringToInt(PromptUserInput("Enter your age: "));

            // Weight input
            float weight = ConvertStringToFloat(PromptUserInput("Enter your weight(in kg): "));

            // Height input
            float height = ConvertStringToFloat(PromptUserInput("Enter your height(in cm): "));

            // BMI calculation
            float bmi = CalculateBMI(weight, height);

            // User profile output
            PrintUserProfile(name, surname, age, weight, height, bmi);
        }

        static string PromptUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static void PrintUserProfile(string name, string surname, int age, float weight, float height, float bmi)
        {
            Console.WriteLine("{0} is {1} years old, his weight is {2} kg and his height is {3} cm\nBMI: {4}",
                name + " " + surname,
                age,
                weight,
                height,
                string.Format("{0:F1}", bmi)
                );
        }

        static float CalculateBMI(float weight, float height)
        {
            float bmi = (weight) / ((height / 100) * (height / 100));
            return bmi;
        }

        static int ConvertStringToInt(string input)
        {
            return Convert.ToInt32(input);
        }

        static float ConvertStringToFloat(string input)
        {
            return float.Parse(input);
        }
    }
}
