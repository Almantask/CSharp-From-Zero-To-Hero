﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization; // NumberStyles.Float, CultureInfo.InvariantCulture

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static void Demo()
        {
            string userName = "", userSurname = "";
            int userAge = 0;
            float userWeight = 0f, userHeight = 0f;

            userName = PromptString("Please input your name.");
            userSurname = PromptString("Please input your surname.");

            Console.WriteLine("Hi " + userName + " " + userSurname + "!");

            userAge = PromptInt("Please input your age.");

            userWeight = PromptFloat("Please input your weight in kg.");
            userHeight = PromptFloat("Please input your height in cm.");

            Console.WriteLine("Calculating BMI for " + userName + "...");
            Console.WriteLine("BMI: " + CalculateBmi(userWeight, userHeight));
        }

        public static int PromptInt(string message)
        {
            bool validInput = false;
            int userInput = 0;

            while (!validInput)
            {
                Console.WriteLine(message);
                string consoleInput = Console.ReadLine();
                validInput = Int32.TryParse(consoleInput, out userInput);

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Invalid number.");
            }

            return userInput;
        }

        public static string PromptString(string message)
        {
            bool validInput = false;
            string userInput = "";

            while (!validInput)
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine().Trim();
                validInput = userInput.Length > 0;

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Empty string.");
            }

            return userInput;
        }

        public static float PromptFloat(string message)
        {
            bool validInput = false;
            float userInput = 0f;

            while (!validInput)
            {
                Console.WriteLine(message);
                string consoleInput = Console.ReadLine();
                validInput = float.TryParse(consoleInput, NumberStyles.Float, CultureInfo.InvariantCulture, out userInput);

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Invalid number.");
            }

            return userInput;
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}