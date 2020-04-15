using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            ProcessPersonBMI(); //Is this what you mean? Demo now calls a function to do the info gathering, which calls the functions to process the input.
            Pause();
            ProcessPersonBMI(); //Second person processing (Could be done by adding a second Demo function to the Main?)
            Pause();
        }
        public static void ProcessPersonBMI()
        {
            //Get input from the user.
            string firstName = GetStringInput("Enter your first name: ");
            string lastName = GetStringInput("Enter your last name: ");
            int age = GetIntInput("Enter your age: ");
            float height = GetFloatInput("Enter your height (in M): "); //Changed from cm to M in order to work with tests.
            float weight = GetFloatInput("Enter your weight (in kg): ");

            //Print back information and follow up with BMI calculation.
            Console.WriteLine($"{firstName} {lastName} is {age} years old, weighs {weight} kg and is {height} M tall.");
            Console.WriteLine($"{firstName}'s BMI is " + CalcBMI(weight, height));
            //Tried breaking these print lines into their own method block, however it would need 5 input parameters and would need to be
            //called in this block to keep the variables in scope, so seemd to be a bit pointless. I imagine there's a better way to do it.
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
        public static void Pause()
        {
            //Pause program so output can be read by user.
            Console.ReadKey();
            Console.Clear();
        }
    }
}
