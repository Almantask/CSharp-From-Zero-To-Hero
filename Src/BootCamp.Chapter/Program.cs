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
            Lesson3.Demo();
        }
        public static string AddNewPerson()
        {
            //Read user data
            string name = PrintMessageAndInputString("What is your name?");
            string surname = PrintMessageAndInputString("What is your surname?");
            int age = PrintMessageAndInputIntager("How old are you?");
            float weight = PrintMessageAndInputFloat("What is your weight (in kg)?");
            float height = PrintMessageAndInputFloat("What is your height (in cm)?");
            //Show message about person
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            //Change cm to m
            float heightInMeters = height / 100;
            float BMI = CalculateBmi(weight,heightInMeters);
            //Show message about person's BMI
            Console.WriteLine("His/her BMI = " + string.Format("{0:N}", BMI)+ " \n");
            
            Console.WriteLine("Do you want to add another person (Y/y = Yes, everything else = No)?");
            string decision = Console.ReadLine();
            //Change decision to upper latter
            string decisionToUpper = decision.ToUpperInvariant();

            return decisionToUpper;
        }
        public static int PrintMessageAndInputIntager(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return int.Parse(input);
        }
        public static float PrintMessageAndInputFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return float.Parse(input);
        }
        public static string PrintMessageAndInputString(string message)
        {
            Console.WriteLine(message);

            return Console.ReadLine();
        }
       
        public static float CalculateBmi(float weight, float height)
        {
            return weight / (float)Pow(height, 2);
        }
        
    }
}