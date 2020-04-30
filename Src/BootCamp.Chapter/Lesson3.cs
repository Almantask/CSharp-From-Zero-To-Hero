using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3        
    {
        public static void Demo()
        {
            CalculateBMI();
            CalculateBMI();
        }
        public static void CalculateBMI()
        {
            string name = stringPrompt("Please input your first name: ");
            string surname = stringPrompt("Please input your last name: ");
            int age = intPrompt("Please input your age: ");
            float weight = floatPrompt("Please input your weight in kg: ");
            float height = floatPrompt("Please input your height in m: ");

            // Output message with info and BMI
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");
            Console.WriteLine(name + "'s body-mass index (BMI) is " + bmiCalculator(weight, height));
        }
        // Input prompt for string
        public static string stringPrompt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return input;
        }
        // Input prompts for int
        public static int intPrompt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            if (string.IsNullOrEmpty(input)) 
                return 0;
            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            return number;
        }
        // Input prompts for float
        public static float floatPrompt(string message)                       
        {
            cultureChange();
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);
            if (string.IsNullOrEmpty(input)) 
                return (float)0;
            if (!isNumber)
            {
                Console.Write( $"\"{input}\" is not a valid number.");
                return (float)-1;
            }
            return number;
        }
        // BMI calculator using weight and height
        public static float bmiCalculator(float weight, float height)
        {
            if (height <= 0f || weight <= 0f)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0f && height <= 0f)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                    Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                    return -1f;
                }
                if (weight <= 0f)
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                if (height <= 0f)
                    Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1f;
            }
            var bmi = weight / (height * height);
            return bmi;
        }
        public static void cultureChange()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
        }
    } 
}