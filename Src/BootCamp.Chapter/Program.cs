using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskingAndConvertingSTRING();
            string surname = AskingAndConvertingSTRING();
            int age = AskingAndConvertingINT();
            float weight = AskingAndConvertingFLOAT();
            float height = AskingAndConvertingFLOAT();

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            float bmi = CalculateBMI(weight, height);

            Console.WriteLine("His BMI is " + bmi + ".");

            // Up - first person, down - second.

            string secondName = AskingAndConvertingSTRING();
            string secondSurname = AskingAndConvertingSTRING();
            int secondAge = AskingAndConvertingINT();
            float secondWeight = AskingAndConvertingFLOAT();
            float secondHeight = AskingAndConvertingFLOAT();

            Console.WriteLine(secondName + " " + secondSurname + " is " + secondAge + " years old, his weight is " + secondWeight + " kg and his height is " + secondHeight + " cm.");

            float secondBmi = CalculateBMI(secondWeight, secondHeight);

            Console.WriteLine("His BMI is " + secondBmi + ".");

            Console.ReadLine();

        }
        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / ((height / 100) * (height / 100));
            return (float)Math.Round(bmi, 1);
        }
        public static int AskingAndConvertingINT()
        {
            int integer = int.Parse(Console.ReadLine());
            return integer;
        }
        public static string AskingAndConvertingSTRING()
        {
            string strings = Console.ReadLine();
            return strings;
        }
        public static float AskingAndConvertingFLOAT()
        {
            float theFloat = float.Parse(Console.ReadLine());
            return theFloat;
        }
    }
}

