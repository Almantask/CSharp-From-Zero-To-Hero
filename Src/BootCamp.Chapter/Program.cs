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
        public static int GetInt(string message)
        {
            Console.Write(message);

            return Convert.ToInt32(Console.ReadLine());
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float GetFloat(string message)
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
