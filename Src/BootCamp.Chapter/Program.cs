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
           ErrorCheck("Age: ");
        }

        static float CalculateBmi(float weight,float height)
        {   
            return weight / height / height *1f ;
            

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
        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return int.Parse(input);

        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return float.Parse(input);

        }
        public static int ParseInt(string input)
        {
            bool isNumber = int.TryParse(input, out var output);

            if (!isNumber) return -1;

            else
            {
                return output;
            }
        }
        public static string ParseName(string input)
        {
            bool isEmpty = string.IsNullOrEmpty(input);

            if (isEmpty) return "x";

            else
            {
                return input;
            }

        }
        public static string Empty(string input)
        {
            bool isEmpty = string.IsNullOrEmpty(input);

            if (isEmpty) return input = null;

            else
            {
                return input;
            }


        }

        static void ErrorCheck(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            var check = ParseInt(Empty(input));

            if (check == -1) Console.WriteLine("Error!: " + input + " is not a number or isn't above 0");
        }

        public static void Test()
        {
            Console.Write("Full Name: ");
            var input = Console.ReadLine();
            var name = ParseName(input);

            if (name == "x") Console.WriteLine("Error!: Name cannot be empty");

            Console.Write("Age: ");
            var input1 = Console.ReadLine();
            var age = ParseInt(Empty(input1));

            if (age == -1) Console.WriteLine("Error!: "+ input1 + "is not a number or isn't above 0");

            Console.Write("Weight (kg): ");
            var input2 = Console.ReadLine();
            var weight = ParseInt(Empty(input2));

            if (weight == -1) Console.WriteLine("Error!: " + input2 + "is not a number or isn't above 0");

            Console.Write("H");


        }

    }
}
