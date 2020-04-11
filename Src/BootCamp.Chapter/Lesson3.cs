using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
             static void GatherInfo(string userNumber)
            {
                Console.WriteLine("\r\nHello! You are the " + userNumber + " user today.");
                string firstName = PromptString("What is your first name?");
                string surName = PromptString("What is your surname?");
                int age = PromptInt("What is your age?");
                float weight = PromptFloat("How much do you weigh(in kg)?");
                float height = PromptFloat("How tall are you(in cm)?");

                float BMI = CalculateBmi(weight, height);

                PrintResult(firstName, surName, age, weight, height, BMI);
            }
            GatherInfo("first");
            GatherInfo("second");
        }
         public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int Age = int.Parse(Console.ReadLine());
            return Age;
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
        private static float ConvertToMeters(float height)
        {
            float mHeight = (height / 100);
            return mHeight;
        }
        public static float CalculateBmi(float weight, float mHeight)
        {
            float BMI = (weight / (mHeight * mHeight));
            return BMI;
        }
        public static void PrintResult(string firstName, string surName, int age, float weight, float height, float BMI)
        {
            Console.WriteLine(firstName + " " + surName + " is " + age + " years old, their weight is " + weight + " kg and they are " + height + " cm tall.\r\nThey have a BMI of " + BMI);
        }
    }
}
