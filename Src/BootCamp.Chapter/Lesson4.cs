using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                Console.WriteLine();
                return 0; 
            }
            bool isNumber = int.TryParse(input, out int num);
            Console.WriteLine();
            if (!isNumber) 
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1; 
            }
            else if (num == 0) { return 0; }
            else { return num; }
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool isString = string.IsNullOrEmpty(input);
            Console.WriteLine();
            if (isString) 
            {
                Console.Write("Name cannot be empty.");
                return "-"; 
            }
            else { return input; }
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                Console.WriteLine();
                return 0; 
            }
            bool isFloat = float.TryParse(input, out float num);
            Console.WriteLine();
            if (!isFloat)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            else if (num <= 0) { return -1; }
            else { return num; }
        }

        public static float CalculateBMI(float weight, float height)
        {
            bool isWeight = true;
            bool isHeight = true;
            if (weight <= 0) { isWeight = false; }
            if (height <= 0) { isHeight = false; }

            if (!isWeight)
            {
                if (!isHeight)
                {
                    Console.WriteLine("Failed calculating BMI. Reason:");
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                    return -1;
                }
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            else if (!isHeight)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return -1;
            }

            return weight / (height * height);
        }
    }
}
