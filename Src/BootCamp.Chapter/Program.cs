using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;


namespace BootCamp.Chapter
{
    class Program
    {


        public static void Main(string[] args)
        {
            PrintDetails();
            PrintDetails();
        }

        public static string GetName(string name)
        {
            Console.WriteLine(name);
            return Console.ReadLine();
        }

        public static int GetAge(string age)
        {
            Console.WriteLine(age);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float GetMeasurements(string measurements)
        {
            Console.WriteLine(measurements);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            float heightMetresSquared = height * height;
            float bmi = weight / heightMetresSquared;
            return bmi;
        }

        public static void PrintDetails()
        {
            string name = GetName("What is your name?: ");
            Console.WriteLine("Hello, " + name + "!");

            int age = GetAge("How old are you?: ");
            float height = GetMeasurements("How tall are you in metres?: ");
            float weight = GetMeasurements("How much do you weigh in kilograms?: ");

            Console.WriteLine(name + " is " + age + " years old, they weigh " + weight + "kg and they are " + height + "m tall!");

            double bmi = CalculateBmi(weight, height);
            Console.WriteLine("Your BMI = " + bmi);
        }
    }
}

