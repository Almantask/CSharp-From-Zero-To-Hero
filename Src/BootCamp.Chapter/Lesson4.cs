using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            CallFunctions("Person 1");
            CallFunctions("Person 2");
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            int number = ParseInt(Console.ReadLine());
            return number;
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            string text = StringCheck(Console.ReadLine());
            return text;
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float number = ParseFloat(Console.ReadLine());
            return number;
        }
        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                CheckValue("Weight", weight);
                CheckValue("Height", height);
                return -1;
            }
            else
            {
                float bmi = weight / (height * height);
                return bmi;
            }            
        }
        public static void CallFunctions(string person)
        {
            Console.WriteLine(person);
            string name = PromptString("Enter your name: ");
            string surname = PromptString("Enter your surname: ");
            int age = PromptInt("Enter your age: ");
            float height = PromptFloat("Enter your height: ");
            float weight = PromptFloat("Enter your weight: ");
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            float bmi = CalculateBmi(weight, height);
            if (bmi != -1)
            {
                Console.WriteLine($"Your BMI is: {bmi}");
            }            
        }
        public static int ParseInt(string input)
        {
            bool isNumber = int.TryParse(input, out int number);
            if (!isNumber)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }
        }
        public static float ParseFloat(string input)
        {
            bool isNumber = float.TryParse(input, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float number);
            if (!isNumber)
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }
        }
        public static string StringCheck(string input)
        {
            bool isNullOrEmpty = string.IsNullOrEmpty(input);
            if (isNullOrEmpty)
            {
                Console.WriteLine($"Name cannot be empty");
                return "-";
            }
            else
            {
                return input;
            }
        }
        public static void CheckValue(string input, float value)
        {
            if (value <= 0)
            {
                Console.WriteLine($"{input} cannot be equal or less than zero, but was {value}.");
            }            
        }
    }
}
