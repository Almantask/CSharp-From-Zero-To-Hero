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
            string nameMessage = "May I have your name?";
            string surnameMessage = "May I have your surname?";
            string ageMessage = "May I have your age?";
            string weightMessage = "May I have your weight(KG)?";
            string heightMessage = "May I have your height(m)?";

            string name = AskingAndConvertingSTRING(nameMessage);
            string surname = AskingAndConvertingSTRING(surnameMessage);
            int age = AskingAndConvertingINT(ageMessage);
            float weight = AskingAndConvertingFLOAT(weightMessage);
            float height = AskingAndConvertingFLOAT(heightMessage);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            float bmi = CalculateBMI(weight, height);

            Console.WriteLine("His BMI is " + bmi + ".");

            // Up - first person, down - second.

            string secondName = AskingAndConvertingSTRING(nameMessage);
            string secondSurname = AskingAndConvertingSTRING(surnameMessage);
            int secondAge = AskingAndConvertingINT(ageMessage);
            float secondWeight = AskingAndConvertingFLOAT(weightMessage);
            float secondHeight = AskingAndConvertingFLOAT(heightMessage);

            Console.WriteLine(secondName + " " + secondSurname + " is " + secondAge + " years old, his weight is " + secondWeight + " kg and his height is " + secondHeight + " cm.");

            float secondBmi = CalculateBMI(secondWeight, secondHeight);

            Console.WriteLine("His BMI is " + secondBmi + ".");

            Console.ReadLine();

        }
        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);
            return (float)Math.Round(bmi, 1);
        }
        public static int AskingAndConvertingINT(string message)
        { 
            Console.WriteLine(message);
            int integer = int.Parse(Console.ReadLine());
            return integer;
        }
        public static string AskingAndConvertingSTRING(string message)
        {
            Console.WriteLine(message);
            string strings = Console.ReadLine();
            return strings;
        }
        public static float AskingAndConvertingFLOAT(string message)
        {
            Console.WriteLine(message);
            float theFloat = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            return theFloat;
        }
    }
}

