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
            Lesson3.Demo();
        }
        public static int getInt(string message)
        {
            Console.Write(message);

            return Convert.ToInt32(Console.ReadLine());
        }

        public static string getString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float getFloat(string message)
        {
            Console.Write(message);
            return (float)Convert.ToDouble(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
