using System;
using static System.Math;
namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string decision;
            do
            {
                Console.Clear(); //Clear console window
                decision = AddNewPerson();

            } while (decision == "Y"); //Repeat if user wants to add new person's data
        }
        public static string AddNewPerson()
        {
            //Read user data
            string name = PromptString("What is your name?");
            string surname = PromptString("What is your surname?");
            int age = PromptInteger("How old are you?");
            float weight = PromptFloat("What is your weight (in kg)?");
            float height = PromptFloat("What is your height (in cm)?");
            //Show message about person
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            //Change cm to m
            float heightInMeters = height / 100;
            float BMI = CalculateBmi(weight, heightInMeters);
            //Show message about person's BMI
            Console.WriteLine("His/her BMI = " + string.Format("{0:N}", BMI) + " \n");

            Console.WriteLine("Do you want to add another person (Y/y = Yes, everything else = No)?");
            string decision = Console.ReadLine();
            //Change decision to upper latter
            string decisionToUpper = decision.ToUpperInvariant();

            return decisionToUpper;
        }
        public static int PromptInteger(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return int.Parse(input);
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return float.Parse(input);
        }
        public static string PromptString(string message)
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
