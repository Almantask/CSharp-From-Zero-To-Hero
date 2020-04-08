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
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            return float.Parse(Console.ReadLine());
            
        }
    }
}
