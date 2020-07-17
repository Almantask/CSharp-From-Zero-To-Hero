using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace BootCamp.Chapter
{
    public class Lesson3
    {
        // Had to implement to make test work with float (. instead of , in test number).
        static CultureInfo invC = CultureInfo.InvariantCulture;
        public static void Demo()
        {
            // Calling all functions and combining output.
            string name = PrintMessageAndReturnString("Please enter your name: ");
            string surname = PrintMessageAndReturnString("Please enter your surname: ");
            int age = PrintMessageAndReturnInt("Please enter your age: ");
            float weight = PrintMessageAndReturnFloat("Please enter your weight (in kg): ");
            float height = PrintMessageAndReturnFloat("Please enter your length (in cm): ");

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg " +
                $"and his height is {height} cm.");
            Console.WriteLine($"{CalculateBMI(weight, height/100):F2}");
            Console.ReadLine();
        }
        public static string PrintMessageAndReturnString(string message)
        {
            Console.Write(message);
            return (Console.ReadLine());
        }
        public static int PrintMessageAndReturnInt(string message)
        {
            Console.Write(message);
            return (int.Parse(Console.ReadLine()));
        }
        public static float PrintMessageAndReturnFloat(string message)
        {
            Console.Write(message);
            return (float.Parse(Console.ReadLine(), invC));
        }
        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
