using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static float weight;
        static float height;

        public static void Demo()
        {
            BMICalculator("Person 1");
            BMICalculator("Person 2");
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }

        public static void BMICalculator(string person)
        {
            string name_first = PromptString("Hello! What's your first name? ");
            string name_last = PromptString("And your last name? ");
            int age = PromptInt("What is your age in years? ");
            height = PromptFloat("What is your heigh in meters?(eg. 1.72) ");
            weight = PromptFloat("What is your weight in kg?(eg. 80.2) ");

            Console.WriteLine($"{name_first} {name_last} is {age} years old! Their weight is {weight} kgs, and their height is {height} meters!");            
            Console.WriteLine($"After calculating it, your BMI comes out to {CalculateBMI(weight, height)}!\n");
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string text = Console.ReadLine();
            return text;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}