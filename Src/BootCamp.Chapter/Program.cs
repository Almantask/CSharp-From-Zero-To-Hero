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
            Print(1);

            Print(2);
        }
        private static void Print(int number)
        {
            Console.WriteLine("Person #" + number + ":");

            Console.Write("Full Name: ");
            Name();
            
            Console.Write("Age: ");
            Age();

            Console.Write("Weight (kg): ");
            Weight();

            Console.Write("Height (cm): ");
            Height();

            Console.WriteLine(Name() + " is " + Age() + " years old, his weight is " + Weight() + " kg, his height is " + Height() + " and his bmi is " + CalculateBmi() + ".");

            Console.WriteLine(" ");

        }

        public static float Age() 
        {           
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string Name()
        {           
            return Convert.ToString(Console.ReadLine());
        }

        public static float Weight()
        {            
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float Height()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static float CalculateBmi()
        {
            float bmi = Weight() / (Height() * Height()) * 10000;
            return bmi;
        }

    }
}
