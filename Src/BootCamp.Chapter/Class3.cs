using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Class3
    {
        internal static void Demo()
        {
            throw new NotImplementedException();
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
            var input = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return input;
        }

    }
}