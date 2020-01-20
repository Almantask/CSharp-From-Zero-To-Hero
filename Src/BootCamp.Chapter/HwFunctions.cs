using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class HwFunctions
    {
        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = float.Parse(Console.ReadLine());
            return input;
        }
        public static float CalculateBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }
    }
}
