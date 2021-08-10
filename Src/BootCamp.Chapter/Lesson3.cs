using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = PromptString("Please enter your name:");
                int age = PromptInt("Please tell me how old you are:");
                int weight = PromptInt("What is your weight?");
                float height = PromptInt("What is your height?");

                float bmi = CalculateBmi(weight, height) * 10000;

                Console.WriteLine($"Welcome {name}, you are {age} years old and have a BMI of {bmi:F2}.");
            }
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}
