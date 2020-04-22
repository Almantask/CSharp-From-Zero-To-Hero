using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            // Person 1 Input (name, age, weight, height)
            var name1 = PromptString("Name: ");
            var age1 = PromptInt("Age: ");
            var weight1 = PromptFloat("Weight: ");
            var height1 = PromptFloat("Height: ");
            
            // Person 1 Output (bmi)   
            Console.WriteLine($"My name is {name1}, I am {age1} years old, my weight is {weight1}, " +
                $"I'm {height1} meters tall and my BMI is {CalculateBMI(weight1, height1)}");

            // Person 2 Input (name, age, weight, height)
            var name2 = PromptString("Name: ");
            var age2 = PromptInt("Age: ");
            var weight2 = PromptFloat("Weight: ");
            var height2 = PromptFloat("Height: ");

            // Person 2 Output (bmi)   
            Console.WriteLine($"My name is {name2}, I am {age2} years old, my weight is {weight2}, " +
                $"I'm {height2} meters tall and my BMI is {CalculateBMI(weight2, height2)}");
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
    }
}
