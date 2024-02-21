using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        
        public static float CalculateBmi(float weight, float height)
        {
            float high = height*height;
            float bmi = weight / high;
            return bmi;

        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            return name;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            float WeightOrHeight = float.Parse(Console.ReadLine());
            return WeightOrHeight;
        }
    }
}
