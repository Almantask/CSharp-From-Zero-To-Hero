using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = PromptName("Please enter your name: ");
            int age = PromptAge("Please enter your age: ");
            float height = PromptHeight();
            float weight = PromptWeight();
            float bmi = CalculateBmi(height, weight);

            //Printout
            Console.WriteLine($" Dear {name}, you are {age} years old. Your weight is {weight} kg and your height is {height} cms. This means that your BMI is {Math.Round(bmi, 2)}.");
        }

        public static string PromptName(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            return name;
        }

        public static int PromptAge(string message)
        {
            Console.WriteLine(message);
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public static float PromptHeight()
        {
            Console.WriteLine("Please enter your height in m:");
            float height = Convert.ToSingle(Console.ReadLine());
            return height;
        }

        public static float PromptWeight()
        {
            Console.WriteLine("Please enter your weight in kg:");
            float weight = Convert.ToSingle(Console.ReadLine());
            return weight;
        }

        public static float CalculateBmi(float height, float weight)
        {
            float bmi = weight / (height* height);
            return bmi;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float number= Convert.ToSingle(Console.ReadLine());
            return number;
        }
    }
}
