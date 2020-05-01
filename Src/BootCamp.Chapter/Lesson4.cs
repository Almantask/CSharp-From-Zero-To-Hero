using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            CalculateBMIPerson();
            CalculateBMIPerson();
        }

        static void CalculateBMIPerson()
        {
            var name = PromptString("Name: ");
            while (name == "-")
            {
                name = PromptString("Name: ");
            }

            var age = PromptInt("Age: ");
            while (age == 0 || age == -1)
            {
                age = PromptInt("Age: ");
            }

            var weight = PromptFloat("Weight: ");
            while (weight == 0 || weight == -1)
            {
                weight = PromptFloat("Weight: ");
            }

            var height = PromptFloat("Height: ");
            while (height == 0 || height == -1)
            {
                height = PromptFloat("Height: ");
            }

            var BMI = CalculateBMI(weight, height);

            Console.WriteLine($"My name is {name}, I am {age} years old, my weight is {weight}, my height is {height} and my BMI is {BMI}");
        }
        
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                return 0; 
            }
            bool isNumber = int.TryParse(input, out int num);
            if (!isNumber) 
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1; 
            }
            else if (num == 0) return 0;
            else return num; 
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                Console.Write("Name cannot be empty.");
                return "-"; 
            }
            else return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                return 0; 
            }
            bool isFloat = float.TryParse(input, out float num);
            if (!isFloat)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            else if (num <= 0) return -1;
            else return num;
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
