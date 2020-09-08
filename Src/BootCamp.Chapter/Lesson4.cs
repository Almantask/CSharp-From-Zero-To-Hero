using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = PromptString("Enter name: ");
            int age = PromptInt("Enter age: ");
            float weight = PromptFloat("Enter weight (kg): ");
            float height = PromptFloat("Enter height (m): ");

            Console.WriteLine($"\n{name} is {age} years old. Their weight is {weight}kg and height is {height}m.");
            Console.WriteLine($"{name}'s BMI is {CalculateBMI(weight, height)}.\n");

            Console.ReadKey();
        }

        public static float CalculateBMI(float weightInKg, float heightInM)
        {
            return weightInKg / (heightInM * heightInM);
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }
    }
}
