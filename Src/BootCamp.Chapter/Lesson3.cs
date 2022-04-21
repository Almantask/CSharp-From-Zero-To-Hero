using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo() 
        {
        
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var number = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
