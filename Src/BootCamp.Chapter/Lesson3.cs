using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            string name = printAndReadString("What is your name?");
            string surename = printAndReadString("What is your surename?");
            int age = printAndReadInt("What is your age?");
            float height = printAndReadFloat("What is your height in meters?");
            float weight = printAndReadFloat("What is your weight in kg?");

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m ");
            Console.WriteLine("Your BMI is " + bmiCalc(weight, height));

            Console.ReadLine();
        }
        public static float bmiCalc(float weight, float height)
        {
            float bmi = (weight / (height * height));
            return bmi;
        }
        public static string printAndReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static int printAndReadInt(string message)
        {
            return Convert.ToInt32(printAndReadString(message));
        }
        public static float printAndReadFloat(string message)
        {
            return Convert.ToSingle(printAndReadFloat(message), CultureInfo.InvariantCulture);
        }
    }
}