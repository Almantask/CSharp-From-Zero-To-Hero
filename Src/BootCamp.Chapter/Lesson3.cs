using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {

        public static void Demo()
        {
            string name = GetString("What's your first name?");
            string surname = GetString("What's your surname?");
            int age = GetInt("How old are you?");
            float weight = GetFloat("How much do you weight in kg?");
            float height = GetFloat("How tall are you in cm?");
            float mHeight = ConvertToMetres(height);
            float bodyMassIndex = CalculateBMI(mHeight, weight);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + " cm");

            Console.WriteLine("Their BMI is: " + bodyMassIndex);
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float GetFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        public static float GetHeight(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBMI(float height, float weight)
        {
            return weight / (height * height);
        }

        private static float ConvertToMetres(float height)
        {
            return height / 100;
        }

    }
}
