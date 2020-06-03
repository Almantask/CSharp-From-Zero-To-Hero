using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
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
            if (name == "-") Console.WriteLine("Name cannot be empty.");

            var surname = PromptString("Surname: ");
            if (surname == "-") Console.WriteLine("Name cannot be empty.");

            var age = PromptInt("Age: ");
            if (age == -1) Console.WriteLine("\"" + age + "\" is not a valid number.");

            var weight = PromptFloat("Weight: ");
            var height = PromptFloat("Height: ");

            // print information back to user
            Console.WriteLine("\n" + name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");

            // calculated BMI using function and store it in "determinedBmi" variable
            var determinedBmi = CalculateBmi(weight, height);

            // check for errors during BMI calculation; otherwise state the BMI
            if (determinedBmi == -1)
            {
                Console.Write("\nFailed calculating BMI. Reason: ");
                if (height <= 0) Console.WriteLine("Height cannot be less than zero, but was " + height + ". \n");
                if (weight <= 0) Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ". \n");
            }
            else Console.WriteLine("BMI for " + name + ": " + determinedBmi + "\n");



        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            var name1 = Console.ReadLine();

            // Checks for empty input. Otherwise continues as normal.
            bool isValidName = !string.IsNullOrEmpty(name1);
            if (isValidName == false)
                return "-";
            return name1;
        }

        public static int PromptInt(string message)
        {
            // Displays request for age from user.
            Console.Write(message);
            // Declares age variable that will store result of below
            int integer;

            var input = Console.ReadLine();

            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true) return 0;
            bool isValid = int.TryParse(input, out integer);
            if (!isValid) return -1;
            else return integer;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);

            float number;

            var input = Console.ReadLine();

            bool isEmpty = string.IsNullOrEmpty(input);
            if (isEmpty == true) return 0;
            bool isValid = float.TryParse(input, out number);
            if (!isValid) return -1;
            else return number;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 || weight <= 0) return -1;

            float determinedBmi = weight / (height * height);
            return determinedBmi;
        }
    }
}
