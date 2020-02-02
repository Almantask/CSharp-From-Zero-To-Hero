using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input person 1
            string firstName = PromptString("first name");
            string lastName = PromptString("last name");
            int age = PromptInt("age");
            float weight = PromptFloat("weight");
            float height = PromptFloat("height");

            // output person 1
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is " + weight + " kg and his/her height is " + height + " cm.");
            float bmi = CalculateBmi(height / 100, weight);
            Console.WriteLine(firstName + " " + lastName + "'s BMI: " + Math.Round(bmi, 2));

            // input person 2
            firstName = PromptString("first name");
            lastName = PromptString("last name");
            age = PromptInt("age");
            weight = PromptFloat("weight");
            height = PromptFloat("height");

            // output person 2
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is " + weight + " kg and his/her height is " + height + " cm.");
            bmi = CalculateBmi(height / 100f, weight);
            Console.WriteLine(firstName + " " + lastName + "'s BMI: " + Math.Round(bmi, 2));
        }

        public static string PromptString(string message)
        {
            Console.Write("Enter " + message + ": ");
            string value = Console.ReadLine();
            return value;
        }

        public static int PromptInt(string message)
        {
            Console.Write("Enter " + message + ": ");
            int value = Int32.Parse(Console.ReadLine());
            return value;
        }

        public static float PromptFloat(string message)
        {
            Console.Write("Enter " + message + ": ");
            float value = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return value;
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            return weightKg / heightM / heightM;
        }
    }
}
