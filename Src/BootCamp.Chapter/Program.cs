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
            Descriptor();
            Descriptor();
        }

        private static void Descriptor()
        {
            //ask user for their name, age, weight, and height
            string name = PromptString("Name: ");
            string surname = PromptString("Surname: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight: ");
            float height = PromptFloat("Height: ");
            
            //print a sentence about user
            Console.WriteLine($"{name} {surname} is {age} years old, their weight is {weight}Kg and their height is {height}cm");

            //calculate and print the BMI of the user
            float bmi = CalculateBMI(weight, height);
            Console.WriteLine($"They have a BMI of {bmi}");
        }

        private static int PromptInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        private static string PromptString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static float PromptFloat(string prompt)
        {
            Console.Write(prompt);
            return float.Parse(Console.ReadLine());
        }

        private static float CalculateBMI(float weight, float height)
        {
            return weight * 10000 / (height * height);
        }
    }
}
