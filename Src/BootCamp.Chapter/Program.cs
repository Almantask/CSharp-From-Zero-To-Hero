using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
        
        public static int PromptInt(string message)
        {
            return Convert.ToInt32(PromptString(message));
        }

        public static float PromptFloat(string message)
        {
            return float.Parse(PromptString(message));
        }
        
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
        }
    }
}
