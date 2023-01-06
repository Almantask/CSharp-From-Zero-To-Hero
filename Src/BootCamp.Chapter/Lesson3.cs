using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            string firstName = PromptString("What is your name?");
            string lastName = PromptString("What is your last name?");
            int age = PromptInt("How old are you?");
            float weight = PromptFloat("What is your weight (kg)?");
            float height = PromptFloat("What is your height (m)?");
            float bmi = CalculateBmi(weight, height);

            Console.WriteLine($"\n{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. BMI is {bmi}.\n");
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = (float)(weight / Math.Pow(height, 2));
            return bmi;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float response = float.Parse(Console.ReadLine());
            return response;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();
            return response;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int response = int.Parse(Console.ReadLine());
            return response;
        }
    }
}
