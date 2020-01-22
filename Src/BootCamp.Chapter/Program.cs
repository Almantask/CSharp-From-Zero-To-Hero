using System;
using System.Globalization; // NumberStyles.Float, CultureInfo.InvariantCulture

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckBmi("Tom", "Jefferson", 19, 50, 156.5f);
            CheckBmi();
        }

        static void CheckBmi()
        {
            string userName;
            CheckForUserInput("Please input your name.", out userName);

            string userSurname;
            CheckForUserInput("Please input your surname.", out userSurname);

            Console.WriteLine("Hi " + userName + " " + userSurname + "!");

            int userAge;
            CheckForUserInput("Please input your age.", out userAge);

            float userWeight;
            CheckForUserInput("Please input your weight in kg.", out userWeight);
            float userHeight;
            CheckForUserInput("Please input your height in cm.", out userHeight);

            CalculateBMI(userName, userSurname, userAge, userWeight, userHeight);
        }

        static void CheckBmi(in string userName, in string userSurname, in int userAge, in float userWeight, in float userHeight)
        {
            CalculateBmi(userName, userSurname, userAge, userWeight, userHeight);
        }

        static void CalculateBmi(in string userName, in string userSurname, in int userAge, in float userWeight, in float userHeight)
        {
            Console.WriteLine("Calculating BMI for " + userName + " " + userSurname + ".");
            Console.WriteLine("Age: " + userAge);
            float bmi = userWeight / (userHeight * userHeight);
            Console.WriteLine("BMI: " + bmi + "\n");
        }

        static void CheckForUserInput(in string outputText, out string userInput)
        {
            bool validInput = false;
            userInput = "";

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

        static void CheckForUserInput(in string outputText, out int userInput)
        {
            bool validInput = false;
            userInput = 0;

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

        static void CheckForUserInput(in string outputText, out float userInput)
        {
            bool validInput = false;
            userInput = 0f;

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
