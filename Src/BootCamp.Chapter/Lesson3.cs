using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
         // Calculates BMI 2 times
         CalculateBMI();
         CalculateBMI();
        }
        public static void CalculateBMI()
        {
         // Get input from user for name,surname,age,weight,height
         string name = stringPrompt("Please input your first name: ");
         string surname = stringPrompt("Please input your last name: ");
         int age = intPrompt("Please input your age: ");
         float weight = floatPrompt("Please input your weight in kg: ");
         float height = floatPrompt("Please input your height in m: ");
                     
         // Output message with info and BMI
         Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");
         Console.WriteLine(name + "'s body-mass index (BMI) is " + bmiCalculator(weight,height));
        }
        // Input prompt for string
        public static string stringPrompt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
        // Input prompts for int
        public static int intPrompt(string message)
        {
            Console.Write(message);
            var input = int.Parse(Console.ReadLine());
            return input;
        }
        // Input prompts for float
        public static float floatPrompt(string message)
        {
            Console.Write(message);
            var input = float.Parse(Console.ReadLine());
            return input;
        }
        // BMI calculator using weight and height
        public static float bmiCalculator(float weight, float height)
        {
            var bmi = weight / (height * height);
            return bmi;
        }
    }
}


