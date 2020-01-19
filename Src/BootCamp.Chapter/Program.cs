using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static float GetBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        public static string GetString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return input; 
        }

        public static int GetInt(string message)
        {
            Console.Write(message);
            var input = int.Parse(Console.ReadLine());
            return input; 
        }

        public static float GetFloat(string message)
        {
            Console.Write(message);
            var input = float.Parse(Console.ReadLine());
            return input;
        }
    }
}
