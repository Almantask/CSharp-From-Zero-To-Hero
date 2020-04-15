using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            //Get input from the user.
            string fName = GetStringInput("Enter your first name: ");
            string lName = GetStringInput("Enter your last name: ");
            int age = GetIntInput("Enter your age: ");
            float height = GetFloatInput("Enter your height (in M): ");
            float weight = GetFloatInput("Enter your weight (in kg): ");

            //Print back information and follow up with BMI calculation.
            Console.WriteLine("{0} {1} is {2} years old, weighs {3} kg and is {4} cm tall.", fName, lName, age, weight, height);
            Console.WriteLine("{0}'s BMI is {1}.", fName, CalcBMI(height, weight));

            //Halt program so output can be read.
            Console.ReadKey();
        }

        public static float CalcBMI(float weight, float height)
        {
            var bmi = weight / (height * height);
            return bmi;
        }
        public static string GetStringInput(string prompt)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();
            return input;
        }
        public static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            var input = int.Parse(Console.ReadLine());
            return input;
        }
        public static float GetFloatInput(string prompt)
        {
            Console.Write(prompt);
            var input = float.Parse(Console.ReadLine());
            return input;
        }
    }
}
