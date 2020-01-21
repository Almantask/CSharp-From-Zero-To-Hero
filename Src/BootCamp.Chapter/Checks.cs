using System;
using System.Globalization; // NumberStyles.Float, CultureInfo.InvariantCulture

namespace BootCampHW
{
    class Lesson3
    {
        public static void Demo()
        {
            string userName = "", userSurname = "";
            int userAge = 0;
            float userWeight = 0f, userHeight = 0f;

            CheckForUserInput("Please input your name.", ref userName);
            CheckForUserInput("Please input your surname.", ref userSurname);

            Console.WriteLine("Hi " + userName + " " + userSurname + "!");

            CheckForUserInput("Please input your age.", ref userAge);

            CheckForUserInput("Please input your weight in kg.", ref userWeight);
            CheckForUserInput("Please input your height in cm.", ref userHeight);

            Console.WriteLine("Calculating BMI for " + userName + "...");
            float bmi = userWeight / (userHeight * userHeight);
            Console.WriteLine("BMI: " + bmi);
        }

        static void CheckForUserInput(in string outputText, ref string userInput)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(outputText);
                userInput = Console.ReadLine().Trim();
                validInput = userInput.Length > 0;

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Empty string.");
            }
        }

        static void CheckForUserInput(in string outputText, ref int userInput)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(outputText);
                string consoleInput = Console.ReadLine();
                validInput = Int32.TryParse(consoleInput, out userInput);

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Invalid number.");
            }
        }

        static void CheckForUserInput(in string outputText, ref float userInput)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(outputText);
                string consoleInput = Console.ReadLine();
                validInput = float.TryParse(consoleInput, NumberStyles.Float, CultureInfo.InvariantCulture, out userInput);

                if (validInput)
                {
                    break;
                }

                Console.WriteLine("Invalid number.");
            }
        }
    }
}