using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = PrintAndReadString("What is your name?");
            string surename = PrintAndReadString("What is your surename?");
            int age = PrintAndReadInt("What is your age?");
            float height = PrintAndReadFloat("What is your height in meters?");
            float weight = PrintAndReadFloat("What is your weight in kg?");

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m ");
            Console.WriteLine("Your BMI is " + BmiCalc(weight, height));

            Console.ReadLine();
        }
        public static float BmiCalc(float weight, float height)
        {
            return (weight / (height * height));
        }
        public static string PrintAndReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static int PrintAndReadInt(string message)
        {
            return Convert.ToInt32(PrintAndReadString(message));
        }
        public static float PrintAndReadFloat(string message)
        {
            return Convert.ToSingle(PrintAndReadString(message), CultureInfo.InvariantCulture);
        }
    }
}