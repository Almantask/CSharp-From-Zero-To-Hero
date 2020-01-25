﻿using System;


namespace BootCamp.Chapter
{    public class Lesson3
    {   public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                GatherData(out string firstName, out string lastName, out int age, out float weight, out float height);
                DisplayOutput(firstName, lastName, age, weight, height);
            }
        }
        public static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            
            if (Empty(value))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return value;
        }
        public static int GetIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();

            if (Empty(value))
                return 0;

            if (int.TryParse(value, out int parsedInt))
            {
                return parsedInt;
            }

            //default case
            BadInput(value);
            return -1;
            
        }
        public static float GetFloatInput(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();

            if (Empty(value))
                return 0;


            if (float.TryParse(value, out float parsedfloat))
            {
                return parsedfloat;
            }

            //default case
            BadInput(value);
            return -1;

        }
        // Input function
        public static void GatherData(out string firstName, out string lastName, out int age, out float weight, out float height)
        {
            firstName = GetStringInput("Hello, What is your First name?");
            lastName = GetStringInput("Hello, What is your Last name?");

            age = GetIntInput("How old are you?");
            weight = GetFloatInput("How much do you weigh in kilograms?");
            height = GetFloatInput("How tall are you?") / 100;
            if (height <= 0)
            {
                Console.WriteLine("Press [Enter] to continue");
                Console.ReadKey();
            }
        }
        // Output function
        public static void DisplayOutput(string first, string last, int age, float weight, float height)
        {
            Console.Clear();
            Console.WriteLine(first + " " + last + " is " + age + " years old; his weight is " + weight + " kg and his height is " + (height * 100) + " cm.");
            Console.WriteLine(first + "'s Body Mass Index is " + CalcBmi(weight, height) + ".");
            Console.WriteLine("\n\n\n\n\nPress Enter");
            Console.ReadLine();
        }
        //Calculate BMI
        public static float CalcBmi(float weight, float height)
        {
            return weight / (height * height);
        }

        public static void BadInput(string value)
        {
            Console.Write("\"" + value.ToString() + "\" is not a valid number.");
        }
        
        public static bool Empty(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return true;
            }

            return false;
        }
        
        //public static void Error()
        //{
        //    Console.WriteLine(string message, )
        //}



        //public static int ValidateInt(int ValidateMe)
        //{
        //    int Result;


        //    return Result;
        //}
    }
}