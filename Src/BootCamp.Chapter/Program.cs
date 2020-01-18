using System;
using static System.Math;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        /*  Homework 3
            1) Fork https://github.com/csinn/CSharp-From-Zero-To-Hero/tree/Chapter1/Homework/3 
            2) Take homework 2 code, place it in the forked branch and refactor it using functions. There should be as little duplicate code as possible (there should be functions for: 
                - Calculating BMI, 
                - Prompt for input and converting it to int, 
                - Prompt for input and converting it to string, 
                - Prompt for input and converting it to float. 
            3) Put all the function you made into the right places in Checks
            4) Move all the code from main function into lesson3 class function called Demo. Call it from main function.
        */

        static void Main(string[] args)
        {
            Demo();
        }
        private static void Demo()
        {
            string decision;
            do
            {
                Console.Clear(); //Clear console window
                decision = AddNewPerson();

            } while (decision == "Y"); //Repeat if user wants to add new person's data
        }
        private static string AddNewPerson()
        {
            //Read name
            string name = InputString("What is your name?");
            //Read surname
            string surname = InputString("What is your surname?");
            //Read age
            int age = InputInteger("How old are you?");
            //Read weight
            float weight = InputFloat("What is your weight (in kg)?");
            //Read height in cm
            float height = InputFloat("What is your height (in cm)?");
            //Show message about person
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            //Change cm to m
            float heightInMeters = height / 100;
            //Calculate BMI
            float BMI = CalculateBMI(weight,heightInMeters);
            //Show message about person's BMI
            Console.WriteLine("His/her BMI = " + string.Format("{0:N}", BMI)+ " \n");
            
            Console.WriteLine("Do you want to add another person (Y/y = Yes, everything else = No)?");
            //Read decision
            string decision = Console.ReadLine();
            //Change decision to upper latter
            string decisionToUpper = decision.ToUpperInvariant();
            return decisionToUpper;
        }
        public static int InputInteger(string message)
        {
            Console.WriteLine(message);
            //Convert to int
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        public static float InputFloat(string message)
        {
            Console.WriteLine(message);
            //Convert to float
            float input = float.Parse(Console.ReadLine());
            return input;
        }
        public static string InputString(string message)
        {
            Console.WriteLine(message);
            //Convert to string
            string input = Console.ReadLine();
            return input;
        }
       
        public static float CalculateBMI(float weight, float height)
        {
            //Calculate BMI
            float bodyMassIndex = weight / (float)Pow(height, 2);
            return bodyMassIndex;
        }
        
    }
}