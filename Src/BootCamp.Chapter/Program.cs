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
            Console.Write("Age: ");
            var input = Console.ReadLine();
            var variable = PromptInt(input);

            if (variable == -1) Console.WriteLine(input + " is not a number");
            else if (variable == 0) Console.WriteLine("Age cannot be empty");
            else
            {
                Console.WriteLine(variable);
            }
        }

        static float CalculateBmi(float weight,float height)
        {   
            return weight / height / height;
            

        }
        public static void Print(int number)
        {
            Console.WriteLine("Person #" + number + ":");

            //input
            var name = PromptString("Full Name: ");

            var age = PromptInt("Age: ");

            var weight = PromptFloat("Weight (kg): ");

            var height = PromptFloat("Height (m): ");


            //output
            Console.WriteLine(" ");
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg, his height is " + height + " and his bmi is " + CalculateBmi(weight,height) + ".");
            Console.WriteLine(" ");
        }


        public static string PromptString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "-";
            }
            else return null;
        }

        static void PrintString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            var name = PromptString(input);

            if (name == "-") Console.WriteLine("");
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return float.Parse(input);

        }
        static void PrintInt(string message, string error)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            var variable = PromptInt(input);

            if (variable == -1) Console.WriteLine(input + " is not a number");
            else if (variable == 0) Console.WriteLine(error + " cannot be empty");
            else
            {
                Console.WriteLine(variable);
            }
        }
        public static int PromptInt(string input)
        {
           
            bool isNumber = int.TryParse(input, out var output);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isNumber) return -1;

            else
            {
                return output;
            }

        }



    }
}
