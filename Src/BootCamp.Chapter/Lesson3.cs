using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = promptString("Please enter your name:");
            int age = promptInt("Please tell me how old you are:");
            int weight = promptInt("What is your weight?");
            float height = promptInt("What is your height?");

            float bmi = calculateBmi(weight, height) * 10000;

            Console.WriteLine($"Welcome {name}, you are {age} years old and have a BMI of {bmi:F2}.");
        }

        public static float calculateBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }

        public static int promptInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static string promptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float promptFloat(string message)
        {
            Console.WriteLine(message);
            float number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}
