using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo()
        {
        }

        public static float CalculateBMI(float weight, float height)
        {
            var heightMeter = height;
            var heightSquared = heightMeter * heightMeter;
            var bmi = weight / heightSquared;
            Console.WriteLine("Your bmi is: " + bmi);
            return bmi;
        }

        public static float ParseBmi(string prompt)
        {
            Console.WriteLine(prompt);
            var bmi = float.Parse(Console.ReadLine());

            return bmi;
        }

        public static int ParseAge(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var age = int.Parse(input);

            return age;
        }

        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            return input;
        }
    }
}