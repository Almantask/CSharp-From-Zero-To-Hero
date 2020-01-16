using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
        // Homework Lesson 1 & 2 - SilentKingdom
            // BMI Calculator for 2 people

            // First person = variable1
            Console.Write("What is your name? ");
            string name1 = Console.ReadLine();
            Console.Write("And how old are you? ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("How much do you weigh (kg)? ");
            float weight1 = float.Parse(Console.ReadLine());
            Console.Write("How tall are you? (cm) ");
            float height1 = float.Parse(Console.ReadLine());
            // Testing string + variable layouts
            Console.WriteLine("\n{0} is {1}, and weighs {2}kg at a height of {3}cm.\n", name1, age1, weight1, height1);

            // Their BMI
            float heightConvert1 = height1 / 100;
            float height_s1 = heightConvert1 * heightConvert1;
            float sum1 = weight1 / height_s1;
            Console.WriteLine(name1 + " has a BMI of " + sum1 + ".");

            // Comparison to Tom Jefferson
            Console.WriteLine("\nWe'll compare " + name1 + "'s BMI with that of a previous subject:\n");

            // Second person = variable2
            const string name2 = "Tom Jefferson";
            const int age2 = 19;
            const float weight2 = 50f;
            const float height2 = 156.5f;
            Console.WriteLine(name2 + " is " + age2 + ", and weighs " + weight2 + "kg at a height of " + height2 + "cm.\n");

            // Their BMI
            const float heightConvert2 = height2 / 100;
            const float height_s2 = heightConvert2 * heightConvert2;
            const float sum2 = weight2 / height_s2;
            Console.WriteLine(name2 + " has a BMI of " + sum2 + ".");
        }
    }
}
