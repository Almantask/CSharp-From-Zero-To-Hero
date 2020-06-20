using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static string name = GetString("Please enter name:");
        static int age = GetInt("Please enter age:");
        static float weight = GetFloat("Please enter weight (in kg):");
        static float height = GetFloat("Please enter height (in cm):");
        static float bmi = GetBMI();


        public static void Demo()
        {

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg, and their height is " + height + " cm.");
            Console.WriteLine("Their BMI is: " + bmi);
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

        public static float GetBMI()
        {
            return (float)Math.Round(weight / ((height / 100f) * (height / 100f)), 2);
        }
    }
}
