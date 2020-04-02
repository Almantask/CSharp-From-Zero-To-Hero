using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        private static int users = 0;
        
        public static void Demo()
        {
            users = PromptInt("How many are you?:");
            if (users > 1)
            {
                for (int i = 1; i <= users; i++)
                {
                    PromptPersonData();
                }
            }                     
        }

        private static void PromptPersonData()
        {            
            string name = PromptString("What is your first name: ");
            string surname = PromptString("What is your last name: ");
            int age = PromptInt("What is your age: ");
            float weight = PromptFloat("what is your weight in Kg: ");
            float height = PromptFloat("what is your height in m (ex. 1.80m): ");
            float bmi = BmiCalculator(weight, height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");

            Console.WriteLine($"Your BMI is {bmi}");            
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }

        public static float BmiCalculator(float weight, float height)
        {
            return weight / (height * height);
        }     
    }
}
