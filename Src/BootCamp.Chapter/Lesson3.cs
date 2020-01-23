using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = PrintAndReadString("Hello, what's the name of the person that you want to calculate the BMI?");
            string surename = PrintAndReadString("What's the surename?");
            int age = PrintAndReadInt("What's the age?");
            float height = PrintAndReadFloat("What's the height in meters?");
            float weight = PrintAndReadFloat("What's the weight in kg?");

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m ");
            Console.WriteLine(name + " " + surename + "'s BMI is " + BmiCalc(weight, height));

            name = PrintAndReadString("Hello, what's the name of the person that you want to calculate the BMI?");
            surename = PrintAndReadString("What's the surename?");
            age = PrintAndReadInt("What's the age?");
            height = PrintAndReadFloat("What's the height in meters?");
            weight = PrintAndReadFloat("What's the weight in kg?");

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m ");
            Console.WriteLine(name + " " + surename + "'s BMI is " + BmiCalc(weight, height));

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
            return Convert.ToSingle(PrintAndReadString(message));
        }
    }
}