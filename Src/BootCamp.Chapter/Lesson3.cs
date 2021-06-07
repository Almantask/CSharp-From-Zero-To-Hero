using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static float weight;
        static float height;
        static float bmi;


        public static void Demo()
        {
            Greeting();
            CalculateBMI();
            GiveUserBMI();
        }

        public static float CalculateBMI()
        {
            bmi = weight / (height * height);
            return bmi;
        }

        public static void Greeting()
        {
            Console.WriteLine("Hello! What is your weight in kg?(eg. 80.1)");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("And what is your heigh in meters?(eg. 1.72)");
            height = float.Parse(Console.ReadLine());
        }

        public static void GiveUserBMI()
        {
            Console.WriteLine(bmi);
            Console.WriteLine($"After calculating it, your BMI comes out to {bmi}!");
        }
    }
}