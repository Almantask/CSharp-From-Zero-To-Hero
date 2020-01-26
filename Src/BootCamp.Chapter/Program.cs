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
            Name();
            Age();
            Stats();
            Calculate();

            //Printout
            Console.WriteLine($" Dear {name} {surname}, you are {age} years old. Your weight is {weight} kg and your height is {height} cms. This means that your BMI is {Math.Round(bmi, 2)}.");
        }

        public static (string, string) Name()
        {
            //Collect name
            Console.WriteLine("Please enter your first name:");
            string name = (Console.ReadLine());
            Console.WriteLine("Please Enter your surname:");
            string surname = (Console.ReadLine());
            return (name, surname);
        }

        public static int Age()
        {
            //Collect age
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public static (float, float) Stats()
        {
            //Collect weight and height
            Console.WriteLine("Please enter your height in cm:");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your weight in kg:");
            float weight = Convert.ToSingle(Console.ReadLine());
            return (height, weight);
        }

        static float Calculate(float weight, float height)
        {
            //Work out BMI
            float bmi = weight / ((height / 100) * (height / 100));
            return bmi;
        }
    }
}
}
