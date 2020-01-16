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
            string name1 = "Tom Jefferson";
            int age1 = 19;
            float weight1 = 50f;
            float height1 = 156.5f;
            // Testing string + variable layouts
            Console.WriteLine("{0} is {1}, and weighs {2}kg at a height of {3}cm.", name1, age1, weight1, height1);

            // Their BMI
            float heightConvert1 = height1 / 100;
            float height_s1 = heightConvert1 * heightConvert1;
            float sum1 = weight1 / height_s1;
            Console.WriteLine(name1 + " has a BMI of " + sum1 + ".");


            // Second person = variable2
            string name2 = "Constance Derpleton";
            int age2 = 24;
            float weight2 = 37f;
            float height2 = 128.4f;
            Console.WriteLine(name2 + " is " + age2 + ", and weighs " + weight2 + "kg at a height of " + height2 + "cm.");

            // Their BMI
            float heightConvert2 = height2 / 100;
            float height_s2 = heightConvert2 * heightConvert2;
            float sum2 = weight2 / height_s2;
            Console.WriteLine(name2 + " has a BMI of " + sum2 + ".");
        }
    }
}
