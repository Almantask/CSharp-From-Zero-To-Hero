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
            ReadPersonDetailsAndCalculateBMI();
            ReadPersonDetailsAndCalculateBMI();
        }

        static void ReadPersonDetailsAndCalculateBMI()
        {
            string firstName = Checks.PromptString("\nEnter the First name:");
            string surName = Checks.PromptString("Enter the Surname:");
            int age = Checks.PromptInt("Enter the age:");
            float weight = Checks.PromptFloat("Enter the weight(kg):");
            float height = Checks.PromptFloat("Enter the height(cm):");
            float heightInMeters = height / 100;
            float bmi = Checks.CalculateBmi(weight, heightInMeters);
            Console.WriteLine($"\n{firstName} {surName} is {age} years old, his weight is {weight} kg and his height is {height} cm ");
            Console.WriteLine($"His BMI is {bmi}");
        }
    }
}
