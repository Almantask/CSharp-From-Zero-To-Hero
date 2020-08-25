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
            GetInfoAndPrint();
            GetInfoAndPrint();
        }

        static void GetInfoAndPrint()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            var age = PromptForInt("Age: ");

            var weight = PromptForFloat("Weight (in kg): ");

            var height = PromptForFloat("Height (in m): ");

            double bmi = CalculateBmi(weight, height);

            Console.WriteLine($"{ name } is { age } years old, his weight is { weight } kg and his height is { height } m. { name }'s BMI is { bmi }.");
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }

        public static float PromptForFloat(string message)
        {
            var invC = CultureInfo.InvariantCulture;

            Console.Write(message);
            var input = float.Parse(Console.ReadLine(), invC);

            return input;
        }

        public static string PromptForString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            return input;
        }

        public static int PromptForInt(string message)
        {
            Console.Write(message);
            var input = int.Parse(Console.ReadLine());

            return input;
        }
    }
}
