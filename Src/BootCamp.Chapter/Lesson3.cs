using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        static string name = GetName();
        static int age = GetAge();
        static float weight = GetWeight();
        static float height = GetHeight();
        static float bmi = GetBMI(weight, height);

        public static void Demo()
        {
            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg, and their height is " + height + " cm.");
            Console.WriteLine("Their BMI is: " + bmi);
        }

        public static string GetName()
        {
            Console.Write("Testing");
            return Console.ReadLine();
        }
        public static int GetAge()
        {
            Console.Write("Testing");
            return int.Parse(Console.ReadLine());
        }
        public static float GetWeight()
        {
            Console.Write("Testing");
            return float.Parse(Console.ReadLine());
        }
        public static float GetHeight()
        {
            Console.Write("Testing");
            return float.Parse(Console.ReadLine());
        }
        public static float GetBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}