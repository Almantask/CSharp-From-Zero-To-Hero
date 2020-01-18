using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static int ConvertStringToInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string ConvertStringToString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float ConvertStringToFloat(string message)
        {
            Console.WriteLine(message);

            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
        public static float Bmi(float weight, float heigth)
        {
            return weight / (float)Math.Pow(heigth, 2);

        }
    }
}
