using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {                      
            string firstName = PromptString("Enter First Name");
            string lastName = PromptString("Enter Last Name");
            int age = PromptInt("Enter Your Age");
            float weight = PromptFloat("Enter Your Weight in KG");
            float height = PromptFloat("Enter Your Height in M");
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine("Your BMI is " + bmi);
            
        }
       

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Convert.ToString(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return (float)Math.Round(weight / height / height, 2);
        }



    }
}
