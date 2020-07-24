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
            Console.WriteLine(message);
            var intToParse = Console.ReadLine();
            var isInt = int.TryParse(intToParse, out int input);
            if (!isInt)
            {
                if (intToParse == "") return 0;
                else
                {
                    Console.WriteLine($"\"{intToParse}\" is not a valid number.");
                    return -1;
                }
            }
            else return input;
            }

            public static string promptString(string message)
            {
            Console.Write(message);
            string word = Console.ReadLine();
            if (word == "")
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else return word;
        }

            public static float promptFloat(string message)
            {
            Console.Write(message);
            var measuring = Console.ReadLine();
            var isValid = float.TryParse(measuring, out var input);
            if(!isValid)
            {
                if(measuring == "" || measuring == "0" || input == 0.0)
                {
                    return 0;
                }
                else
                {
                    Console.WriteLine($"\"{measuring}\" is not a valid number.");
                    return -1;
                }
            }
            return input;
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
