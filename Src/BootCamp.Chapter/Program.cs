using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            AskUserQuestionsAndUserPrintProfile();
            AskUserQuestionsAndUserPrintProfile();
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float input = float.Parse(Console.ReadLine());
            return input;
        }

        public static float CalculateBMI(float weightKG, float heightMetres)
        {
            float bmi = (weightKG / heightMetres) / heightMetres;
            return bmi;
        }

        public static void PrintUserProfile(string name, string surname, int age, float weight, float height, float bmi)
        {
            Console.WriteLine("{0} is {1} years old, his weight is {2} kg and his height is {3} cm\nBMI: {4}",
                name + " " + surname,
                age,
                weight,
                height,
                string.Format("{0:F1}", bmi)
                );
        }

        static void AskUserQuestionsAndUserPrintProfile()
        {
            string name = PromptString("Enter your name: ");
            string surname = PromptString("Enter your surname: ");
            int age = PromptInt("Enter your age: ");
            float weight = PromptFloat("Enter your weight(in kg): ");
            float height = PromptFloat("Enter your height(in cm): ");
            float bmi = CalculateBMI(weight, (height / 100));

            PrintUserProfile(name, surname, age, weight, height, bmi);
        }
    }
}
