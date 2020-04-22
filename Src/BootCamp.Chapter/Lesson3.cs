using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
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
            return weight / (height * height);
        }

        // Prompts the user for an input, converts it to an integer and returns it
        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return int.Parse(input);
        }

        // Prompts the user for a string and returns it (default is a string)
        public static string PromptString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return input;
        }

        // Prompts the user for an input, converts it and returns a float
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return float.Parse(input);
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
    }
}
