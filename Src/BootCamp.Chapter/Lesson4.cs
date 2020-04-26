using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            // Calculates 2 people's BMIs
            CalculateBMIPerson();
            CalculateBMIPerson();
        }
       
        // Takes the weight and height and returns BMI
        public static float CalculateBMI(float weight, float height)
        {
            float isWeight = ParseFloat(weight);
            float isHeight = ParseFloat(height);
            bool isFail = false;

            if (isWeight == -1)
            {
                Console.WriteLine("Failed Calcuating BMI.  Reason: ");
                isFail = true;
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
            }
            if (isHeight == -1)
            {
                if (isFail == true) { Console.WriteLine($"Height cannot be equal or less than zero, but was {height}"); }
                else
                {
                    Console.WriteLine("Failed Calculating BMI.  Reason:");
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}");
                }
            }
            
            return weight / (height * height);
        }

        // Prompts the user for an input, converts it to an integer and returns it
        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return ParseNumber(input);
        }

        // Prompts the user for a string and returns it (default is a string)
        public static string PromptString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            var parseInput = ParseString(input);
            if (parseInput.Equals("-"))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            else { return input; }
        }

        // Prompts the user for an input, converts it and returns a float
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return ParseFloat(input);
        }

        static void CalculateBMIPerson()
        {
            // Input Information (name, age, weight, height)
            var name = PromptString("Name: ");
            var age = PromptInt("Age: ");
            var weight = PromptFloat("Weight: ");
            var height = PromptFloat("Height: ");

            // Output (bmi)   
            Console.WriteLine($"My name is {name}, I am {age} years old, my weight is {weight}, " +
                $"I'm {height} meters tall and my BMI is {CalculateBMI(weight, height)}");
        }

        static int ParseNumber(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);
            
            // If the boolean is false, it is not a number, therefore return -1
            if (!isNumber) { return -1; }
            // If the number is equal to 0, return 0
            else if (number == 0) { return 0;  }
            // Otherwise it's valid input, so we return the input
            else { return number;  }
        }

        static string ParseString(string input)
        {
            // Checks the string
            bool isEmpty = string.IsNullOrEmpty(input);
            // If the string is empty or null, we print an error statement and return -
            if (!isEmpty) { return "-"; }
            // Otherwise the input is correct, so we return it
            else { return input;  }

        }

        static float ParseFloat (string input)
        {
            float num;
            bool isFloat = float.TryParse(input, out num);
            
            // If it's not a float, return -1
            if (!isFloat) { return -1; }
            // If the number is less than or equal to 0, return -1 (or if it's not a float)
            if (num <= 0) { return -1;  }
            // Otherwise, we have valid input, return it!
            else { return num;  }
        }
    }
}
