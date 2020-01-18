﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        public static string firstName;
        public static string surname;
        public static int age;
        public static float weight;
        public static float height;
        public static float bmi;

        static void Main(string[] args)
        {
            var doAnotherPerson = true;
            while (doAnotherPerson)
            {
                GetUserInfo();
                PrintUserInfo();

                var answer = PromptString("\nDo you want to check BMI for another person? y/n: ").ToLowerInvariant();
                doAnotherPerson = answer.Equals("y") || answer.Equals("yes");
            }
        }
        public static void GetUserInfo()
        {
            firstName = PromptString("First Name: ");
            surname = PromptString("Surname: ");
            age = PromptInt("Age: ");
            weight = PromptFloat("Weight in kilograms: ");
            height = PromptFloat("Height in meters: ");
            bmi = CalculateBmi(weight, height);
        }
        public static void PrintUserInfo()
        {
            Console.WriteLine(firstName + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("Body-mass index (BMI) is: " + bmi.ToString("n2"));
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
        }
        public static float CalculateBmi(float weight, float height)
        {
            return weight / height / height;
        }

    }
}
