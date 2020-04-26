using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Body-Mass Index (BMI) Calculator");
            Console.WriteLine("");

            ProcessPersonBMI();
            ProcessPersonBMI();
        }

        private static void ProcessPersonBMI()
        {
            string name = PromptString("What's your name?");
            int age = PromptInt("How old are you?");
            float height = PromptFloat("What's your height? (in m)");
            float weight = PromptFloat("What's your weight? (in kg)");

            Console.WriteLine($"{name} is {age} years old, his weight is {weight}kg and his height is {height}m. ");
            Console.WriteLine($"His BMI is {CalculateBMI(weight, height)}");
            Console.WriteLine("");
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Int32.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
