using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            CalculateBMIPerson();
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return float.Parse(input, CultureInfo.InvariantCulture);
        }

        static void CalculateBMIPerson()
        {
            var name = PromptString("Name: ");
            var surname = PromptString("Surname: ");
            var age = PromptInt("Age: ");
            var weight = PromptFloat("Weight (kg): ");
            var height = PromptFloat("Height (m): ");


            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} and his height is {height} m");
            Console.WriteLine($"{name}'s BMI is: {CalculateBMI(weight, height)}");

        }
    }
}

