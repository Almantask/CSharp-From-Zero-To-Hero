using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {

        public static void Demo()
        {
            Console.WriteLine("Demo works");
        }

        public static float CalculateBmi(float weight, float height)
        {
            var Bmi = weight / height / height;
            return Bmi;
        }

        public static int PromptInt(string message)
        {
            Console.Write("Please give me a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            Console.Write("Please give me a color: ");
            return Convert.ToString(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write("Please give me a simple number: ");
            return float.Parse(Console.ReadLine());
            
        }
    }
}
