using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        // Validates Number Input
        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            int num;
            bool isInt = int.TryParse(input, out num);
            if (!isInt) { return -1; }
            else if (num == 0) { return 0; }
            else { return num; }
        }

        // Validates String Input
        public static string PromptString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            bool isEmpty = string.IsNullOrEmpty(input);
            if (!isEmpty) { return "-"; }
            else { return input; }
        }

        public static bool ValidateBMI(float weight, float height)
        {
            bool isWeight = true;
            bool isHeight = true;
            
            if (height <= 0) { isHeight = false; }
            if (weight <= 0) { isWeight = false; }
            if (!isWeight && !isHeight)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return false;
            }
            else if (!isWeight)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return false;
            }
            else if (!isHeight)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return false;
            }
            else { return true; }
        }

        static void CalculateBMIPerson()
        {
            // Input Information (name, age, weight, height)
            var name = PromptString("Name: ");
            if (name.Equals("-")) 
            { 
                Console.WriteLine("Name cannot be empty.");
                return;
            }
            
            var age = PromptInt("Age: ");
            var weight = PromptFloat("Weight: ");
            var height = PromptFloat("Height: ");
            var isValidBMI = ValidateBMI(weight, height);
            if (!isValidBMI) { return; }

            // Output (bmi)   
            Console.WriteLine($"My name is {name}, I am {age} years old, my weight is {weight}, " +
                $"I'm {height} meters tall and my BMI is {CalculateBMI(weight, height)}");
        }

        public static float CalculateBMI(float weight, float height)
        {
            var isValidBMI = ValidateBMI(weight, height);
            if (!isValidBMI) { return -1; }
            
            return weight / (height * height);
        }







        public static void Demo()
        {
            // Calculates 2 people's BMIs
            CalculateBMIPerson();
            CalculateBMIPerson();
        }

        
        
        

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            float num;
            bool isFloat = float.TryParse(input, out num);
            if (!isFloat) { return -1; }
            else { return num; }
        }






        // Takes the weight and height and returns BMI
        

        // Prompts the user for an input, converts it to an integer and returns it
        

        

        // Prompts the user for an input, converts it and returns a float
        

        

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
