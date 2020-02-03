using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            PromptPersonData();
            PromptPersonData();
        }

        private static void PromptPersonData()
        {
            // input
            string firstName = PromptString("Enter first name: ");
            string lastName = PromptString("Enter last name: ");
            int age = PromptInt("Enter age: ");
            float weight = PromptFloat("Enter weight: ");
            float height = PromptFloat("Enter height: ");

            // output
            PrintPersonDataAndCalculateBmi(firstName, lastName, age, weight, height);
        }

        private static void PrintPersonDataAndCalculateBmi(string firstName, string lastName, int age, float weight, float height)
        {
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is " + weight + " kg and his/her height is " + height + " cm.");
            float bmi = CalculateBmi(weight, height / 100);
            Console.WriteLine(firstName + " " + lastName + "'s BMI: " + Math.Round(bmi, 2));
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return Int32.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            return weightKg / heightM / heightM;
        }
    }
}
