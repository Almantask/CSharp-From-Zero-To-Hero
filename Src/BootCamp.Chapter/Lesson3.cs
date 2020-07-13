using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Person 1:");
            PersonInformation();

            // Person 2
            Console.WriteLine("Person 2:");
            PersonInformation();
        }

        private static void PersonInformation()
        {
            string name = PromptStringInput("Please provide your name: ");
            string surname = PromptStringInput("Please provide your surname: ");
            int age = PromptIntInput("Please provide your age: ");
            int weight = PromptIntInput("Please provide your weigth in kg: ");
            float height = PromptFloatInput("Please provide your height in cm: ");

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine("Their BMI is: " + bmi);
        }

        public static float CalculateBmi(float weight, float height)
        {
            float heightInMeters = height;
            float bmi = weight / (heightInMeters * heightInMeters);
            return bmi;
        }

        public static int PromptIntInput(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static string PromptStringInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float PromptFloatInput(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
    }
}
