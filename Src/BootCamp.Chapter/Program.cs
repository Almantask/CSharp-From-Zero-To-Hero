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
            var name = promptString("Please enter name ");
            var surname = promptString("Please enter surname ");
            var age = promptInt("Please enter an age ");
            var weight = promptFloat("Please enter your weight in kg ");
            var height = promptFloat("Please enter your height in m ");
            var bmi = calculateBmi(weight, height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"Also the BMI is {bmi}.");
        }
        
        public static int promptInt(string message)
        {
            Console.Write(message + Environment.NewLine);
            string intToParse = Console.ReadLine();
            if (string.IsNullOrEmpty(intToParse)) return 0;
            var isValid = int.TryParse(intToParse, out int input);
            if (isValid == false)
            {
                Console.Write($"\"{intToParse}\" is not a valid number.");
                return -1;
            }
            else return input;
        }

        public static string promptString(string message)
        {
            Console.Write(message + Environment.NewLine);
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            else return word;
        }

        public static float promptFloat(string message)
        {
            Console.Write(message + Environment.NewLine);
            var measuring = Console.ReadLine();
            if (string.IsNullOrEmpty(measuring)) return 0;
            var isValid = float.TryParse(measuring, out var input);
            if(isValid == false)
            {
                Console.Write($"\"{measuring}\" is not a valid number.");
                return -1;
            }
            
            else return input;
        }


        public static float calculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                return -1;
            }
                var bmi = weight / (height * height);
                Console.WriteLine($"Also the BMI is {bmi}.");
                return bmi;
        }
        
    }
}
