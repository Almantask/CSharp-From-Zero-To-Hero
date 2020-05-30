using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main(string[] args)
        {

            BmiPrompt();
            BmiPrompt();

            Console.ReadKey();

        }

        public static void BmiPrompt()
        {
            //  obtain information from user
            var name = PromptString("Name: ");
            var surname = PromptString("Surname: ");
            var age = PromptInt("Age: ");
            var weight = PromptFloat("Weight: ");
            var height = PromptFloat("Height: ");

            // print information back to user
            Console.WriteLine("\n" + name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");

            // calculated BMI using function and store it in "determinedBmi" variable
            var determinedBmi = CalculateBmi(weight, height);
            Console.WriteLine("BMI for " + name + ": " + determinedBmi + "\n");

        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        public static int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            float determinedBmi = weight / (height * height);
            return determinedBmi;
        }
    }
}
 