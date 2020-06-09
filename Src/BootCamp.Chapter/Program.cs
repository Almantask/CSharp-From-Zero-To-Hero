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

            var weight = PromptFloat("Weight: ");
            var height = PromptFloat("Height: ");

            // print information back to user
            Console.WriteLine("\n" + name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");

            // calculated BMI using function and store it in "determinedBmi" variable
            var determinedBmi = CalculateBmi(weight, height);

            // check for errors during BMI calculation; otherwise state the BMI
            if (determinedBmi == -1)
            {
                Console.WriteLine("\nFailed calculating BMI. Reason: ");
                if (height <= 0) Console.WriteLine("Height cannot be less than zero, but was " + height + ". ", Environment.NewLine);
                if (weight <= 0) Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ". ", Environment.NewLine);
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

            // Declares the variable that will store result of what happens below.
            int ValidInput;

            var UserInput = Console.ReadLine();

            // Checks for valid input
            bool isEmpty = string.IsNullOrEmpty(UserInput);
            if (isEmpty == true) return 0;

            bool isValid = int.TryParse(UserInput, out ValidInput);
            if (!isValid)
            {
                Console.WriteLine("\"" + UserInput + "\" is not a valid number.");
                return -1;
            }
            else return ValidInput;
        }

        public static float PromptFloat(string message)
        {
            // Displays request for height or weight from user.
            Console.Write(message);

            // Declares a variable that will store the result of the checks below.
            float ValidInput;

            var UserInput = Console.ReadLine();

            // Checks for valid input
            bool isEmpty = string.IsNullOrEmpty(UserInput);
            if (isEmpty == true) return 0;

            bool isValid = float.TryParse(UserInput, out ValidInput);
            if (!isValid) return -1;
            else return ValidInput;
        }

        // BMI calculation checks if EITHER height or weight are invalid, if so return error code "-1"
        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 || weight <= 0) return -1;

            float determinedBmi = weight / (height * height);
            return determinedBmi;
        }
    }
}
