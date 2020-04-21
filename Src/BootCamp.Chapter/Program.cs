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

        static string AskName(string nameInput)
        {
            bool isInvalidName;
            Console.WriteLine(nameInput);
            string name = Console.ReadLine();
            isInvalidName = string.IsNullOrEmpty(name);
            if (isInvalidName)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
                return name;
        }

        static int AskAge(string agePrompt)
        {
            bool isValidAge;
            Console.WriteLine(agePrompt);
            string ageString = Console.ReadLine();
            isValidAge = string.IsNullOrEmpty(ageString); 
            if (isValidAge) return 0; 
            isValidAge = int.TryParse(ageString, out int age);
            if(!isValidAge || age < 0 )
            { Console.WriteLine((char)34 + ageString + (char)34 + " is not a valid number.");
                return -1;
            }
                return age;
        }

        static float AskMeasurements(string measurementPrompt)
        {
            bool isValidMeasurement;
            Console.WriteLine(measurementPrompt);
            string measurementString = Console.ReadLine();
            isValidMeasurement = string.IsNullOrEmpty(measurementString);
            if (isValidMeasurement) return 0;
            isValidMeasurement = float.TryParse(measurementString, out var measurement);
            if(!isValidMeasurement)
            {
                Console.WriteLine((char)34 + measurementString + (char)34 + " is not a valid number.");
                return -1;
            }
                return measurement;
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
                return -1;
            }
            else if (height <= 0 && weight > 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else if (height > 0 && weight <= 0) 
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
                float heightInMetersSquared = height / 100.0f;
            heightInMetersSquared *= heightInMetersSquared;
            var bodyMassIndex = weight / heightInMetersSquared;
            return bodyMassIndex;
        }

        static void PrintBMI()
        {
            string name1 = AskName("What is the patient's name?");
            int age1 = AskAge("How old are they?");
            float weight1 = AskMeasurements("What is their weight in kg?");
            float height1 = AskMeasurements("What is their height in cm?");
            var bmi = CalculateBodyMassIndex(height1, weight1);
            Console.WriteLine(name1 + " is " + age1 + " years old, their weight is " + weight1 + " kg and their height is " + height1 + " cm.");
            Print(name1, bmi);
        }
    }
}

