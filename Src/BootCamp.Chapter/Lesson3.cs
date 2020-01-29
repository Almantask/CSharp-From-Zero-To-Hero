using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string firstName = PromptString("Enter your first name: ");
            string lastName = PromptString("Enter your last name: ");
            int age = PromptInt("Enter your age: ");
            float weight = PromptFloat("Enter your weight (in kg): ");
            float height = PromptFloat("Enter your height (in meters): ");
            float bmi = CalculateBmi(weight, height);

            Console.WriteLine("{0} {1} is {2} years old, he has a BMI of {3} with a weight of {4} kg and a height of {5} meters.", firstName, lastName, age, bmi, weight, height);
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
