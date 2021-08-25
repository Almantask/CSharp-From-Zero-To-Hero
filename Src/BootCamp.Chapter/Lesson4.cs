using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = PromptString("Please enter your name:");
                int age = PromptInt("Please tell me how old you are:");
                int weight = PromptInt("What is your weight?");
                float height = PromptInt("What is your height?");

                float bmi = CalculateBmi(weight, height) * 10000;

                Console.WriteLine($"Welcome {name}, you are {age} years old and have a BMI of {bmi:F2}.");
            }
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}. {Environment.NewLine} Height cannot be equal or less than zero, but was {height}. {Environment.NewLine} Failed calculating BMI. Reason: ");
                return -1;
            }
            if (weight <= 0)
            {
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}. {Environment.NewLine} Failed calculating BMI. Reason:");
                return -1;
            }
            if (height <= 0)
            {
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}. {Environment.NewLine} Failed calculating BMI. Reason:");
                return -1;
            }

            return weight / (height * height);
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            bool succes = int.TryParse(input, out int number);
            if (!succes)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return name;
            }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            bool succes = float.TryParse(input, out float number);
            if (!succes)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            return number;
            }
    }
}