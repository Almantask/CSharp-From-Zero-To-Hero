using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            //Console.Write("Enter your first name: ");
            //    string firstName = Console.ReadLine();
            string firstName = PromptString("Enter your first name: ");

            //Console.Write("Enter your last name: ");
            //    string lastName = Console.ReadLine();
            string lastName = PromptString("Enter your last name: ");

            //Console.Write("Enter your age: ");
            //    string age = Console.ReadLine();
            int age = PromptInt("Enter your age: ");

            //Console.Write("Enter your weight (in kg): ");
            //    float weight = float.Parse(Console.ReadLine());
            float weight = PromptFloat("Enter your weight (in kg): ");

            //Console.Write("Enter your height (in cm): ");
            //    float height = float.Parse(Console.ReadLine());
            float height = PromptFloat("Enter your height (in meters): ");

            //float bmi = (weight / ((height * height) / 100)) * 100;
            float bmi = CalculateBmi(weight, height);

            Console.WriteLine("{0} {1} is {2} years old, his weight is {3} kg and his height is {4} meters.", firstName, lastName, age, weight, height);
            Console.WriteLine("His BMI is {0}.", bmi);
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            // TODO: check input can be parsed as int
            return int.Parse(input);
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            // TODO: check input can be parsed as float
            return float.Parse(input);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
