using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        public static void Demo()
        {
            PersonInformation();
            PersonInformation();
        }

        public static void PersonInformation()
        {
            string name = PromptString("Please enter your Full Name: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight in kg: ");
            float height = PromptFloat("Height in kg: ");
            float bmi = CalculateBMI(weight, height);

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");
            Console.WriteLine(name + "'s BMI is " + bmi);
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return Convert.ToSingle(Console.ReadLine());
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }

    }
}
    