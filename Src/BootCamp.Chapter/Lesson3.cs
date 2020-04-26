using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            ProcessPersonInfo();
            ProcessPersonInfo();
        }

        public static void ProcessPersonInfo()
        {
            string name = PromptString("Name: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight in kg: ");
            float height = PromptFloat("Height in metres: ");
            float bmi = CalculateBMI(weight, height);

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " m.");
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
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }
    }
}
