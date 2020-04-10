using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
         //not sure how to call functions within here.  Test says it cannot find them.

        }

        public static float CalculateBmi(float Weight, float Height)
        {
            var Bmi = Weight / Height / Height;
            return Bmi;
        }
        
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
    }
}
