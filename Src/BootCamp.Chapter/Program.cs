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
            PrintBMI();
            PrintBMI();
        }

        // constant return values for invalid input
        public const int InvalidInt = -1;
        public const float InvalidFloat = -1;
        public const string InvalidString = "-";
        // constant string for quotes
        public const string myStrQuote = "\"";


        //Takes a string from the console and checks its validity
        static string PromptString(string message)
        {
            Console.WriteLine(message);
            string validString = Console.ReadLine();

            if (string.IsNullOrEmpty(validString))
            {
                Console.WriteLine("Name cannot be empty.");
                return InvalidString;
            }
            return validString;
        }

        //Takes a string from the console, converts it to an integer, and checks its validity
        static int PromptAge(string message)
        {
            Console.WriteLine(message);
            string intString = Console.ReadLine();
            if (string.IsNullOrEmpty(intString)) return 0;

            bool isValidInt = int.TryParse(intString, out int validInt);
            if (!isValidInt || validInt < 0)
            {
                Console.WriteLine(myStrQuote + intString + myStrQuote + " is not a valid number.");
                return InvalidInt;
            }

            return validInt;
        }

        //Takes a string from the console, converts it to a float, and checks its validity
        static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string floatString = Console.ReadLine();
            if (string.IsNullOrEmpty(floatString)) return 0;

            bool isValidFloat = float.TryParse(floatString, out var validFloat);
            if (!isValidFloat)
            {
                Console.WriteLine(myStrQuote + floatString + myStrQuote + " is not a valid number.");
                return InvalidFloat;
            }
            
            return validFloat;
        }

        static void Print(string name1, double bmi)
        {
            Console.WriteLine(name1 + "'s BMI is " + bmi);
        }

        static float CalculateBodyMassIndex(float height, float weight)
        {   if(height <= 0 && weight <= 0) 
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return InvalidFloat;
            }
            else if (height <= 0 && weight > 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return InvalidFloat;
            }
            else if (height > 0 && weight <= 0) 
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                return InvalidFloat;
            }

            float heightInMetersSquared = height / 100.0f;
            heightInMetersSquared *= heightInMetersSquared;
            var bodyMassIndex = weight / heightInMetersSquared;
            return bodyMassIndex;
        }

        static void PrintBMI()
        {
            string name1 = PromptString("What is the patient's name?");
            int age1 = PromptAge("How old are they?");
            float weight1 = PromptFloat("What is their weight in kg?");
            float height1 = PromptFloat("What is their height in cm?");
            var bmi = CalculateBodyMassIndex(height1, weight1);
            Console.WriteLine(name1 + " is " + age1 + " years old, their weight is " + weight1 + " kg and their height is " + height1 + " cm.");
            Print(name1, bmi);
        }
    }
}

