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
            Lesson3 L3 = new Lesson3();
            L3.Demo();            
        }
        
        
        
        public static string GetStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;

        }
        public static float GetFloatInput(string prompt)
        {
            Console.WriteLine(prompt);
            float input = float.Parse(Console.ReadLine());

            return input;
        }

        
        
        // INput function
        public static void GatherData(ref string firstName, ref string lastName, ref int age, ref float weight, ref float height)
        {
            firstName = GetStringInput("Hello, What is your First name? ");
            lastName = GetStringInput("Hello, What is your Last name? ");

            age = (int)GetFloatInput("How old are you?");
            weight = GetFloatInput("How much do you weigh in kilograms?");
            height = GetFloatInput("How tall are you?") / 100;
            Console.Clear();
        }



        // Output function
        public static void DisplayOutput(string first, string last, int age, float weight, float height)
        {
            Console.WriteLine(first + " " + last + " is " + age + " years old; his weight is " + weight + " kg and his height is " + (height * 100) + " cm.");
            Console.WriteLine(first + "'s Body Mass Index is " + CalcBmi(weight, height) + ".");
            Console.WriteLine("\n\n\n\n\nPress Enter");
            Console.ReadLine();
        }

        
        
        //Calculate BMI
        public static float CalcBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;

        }
    }
    
    
    
    public class Lesson3
    {
        public void Demo()
        {


            string firstName = " ";
            string lastName = " ";
            int age = 0;
            float weight = 0.00f;
            float height = 0.00f;



            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Program.GatherData(ref firstName, ref lastName, ref age, ref weight, ref height);
                Program.DisplayOutput(firstName, lastName, age, weight, height);
            }
        }
       
    }
}
