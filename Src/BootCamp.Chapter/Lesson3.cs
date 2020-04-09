using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {

        public static void Demo()
        {
            PromptPersonalInfo();
            PromptPersonalInfo();
        }

        public static void PromptPersonalInfo()
        {
            string name = PromptString(message: "Input your name: ");
            string surname = PromptString(message: "Input your surname: ");
            int age = PromptInt(message: "Input your age: ");
            float height = PromptFloat(message: "Input your height in meters: ");
            float weight = PromptFloat(message: "Input your weight in kg: ");
            float bmi = CalculateBMI(weight: weight, height: height);

            Console.WriteLine(name + " " + surname + " " + "is" + " " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m and his/her BMI is: " + bmi);
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string text = Console.ReadLine();

            return text;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float value = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return value;
        }

        public static int PromptInt (string message)
        {
            Console.WriteLine(message);
            int value = Convert.ToInt32(Console.ReadLine());

            return value;
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);

            return bmi;
        }
    }
}
