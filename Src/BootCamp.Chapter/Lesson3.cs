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

        public static int Bmi(int Weight, int Height)
        {
            //Console.Write("Please give me your weight");
            //var Weight = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please give me your height");
            //var Height = Convert.ToInt32(Console.ReadLine());
            var bmi = Weight / Height / Height;
            //Console.WriteLine("Your BMI is " + bmi);
            return bmi;
        }

        public static int Numbers()
        {
            Console.Write("Please give me a number: ");
            var Number2 = Convert.ToInt32(Console.ReadLine());
            return Number2;
        }

        public static string Colors()
        {
            Console.Write("Please give me a color: ");
            var Color = Convert.ToString(Console.ReadLine());
            return Color;
        }

        public static float Balloon()
        {
            Console.Write("Please give me a simple number: ");
            float rubber = float.Parse(Console.ReadLine());
            return rubber;
        }
    }
}
