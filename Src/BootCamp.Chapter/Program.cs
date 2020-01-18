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

            string firstName = " ";
            string lastName = " ";
            int age = 0;
            float weight = 0.00f;
            float height = 0.00f;



            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                gatherData(ref firstName, ref lastName, ref age, ref weight, ref height);
               
                displayOutput(firstName, lastName, age, weight, height);

            }


            
        }
        public static string getStringInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input =  Console.ReadLine();

            return input;

        }



        public static float getFloatInput(string prompt)
        {
            Console.WriteLine(prompt);
            float input = float.Parse(Console.ReadLine());

            return input;
        }

        // INput function
        public static void gatherData(ref string firstName, ref string lastName, ref int age, ref float weight, ref float height)
        {



           
            firstName = getStringInput("Hello, What is your First name? ");
            lastName = getStringInput("Hello, What is your Last name? ");
            
            age = (int)getFloatInput("How old are you?");
            weight = getFloatInput("How much do you weigh in kilograms?");
            height = getFloatInput("How tall are you?")/100;
            Console.Clear();
        }


        // Output function
        public static void displayOutput(string first, string last, int age, float weight, float height)
        {
            Console.WriteLine(first + " " + last + " is " + age + " years old; his weight is " + weight + " kg and his height is " + (height*100) + " cm.");
            Console.WriteLine(first + "'s Body Mass Index is " + calcBMI(weight, height) + ".");
            Console.WriteLine("\n\n\n\n\nPress Enter");
            Console.ReadLine();

        }

        //Calculate BMI
        public static float calcBMI(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;

        }
    }
}
