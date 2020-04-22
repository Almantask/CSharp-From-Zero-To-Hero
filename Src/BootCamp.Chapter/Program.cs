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
            Print(1);

            Print(2);
        }

        static float CalculateBmi(float weight,float height)
        {   
            return weight / height / height * 10000f;


        }
        public static void Print(int number)
        {
            Console.WriteLine("Person #" + number + ":");

            //input
            var name = PromptString("Full Name: ");

            var age = PromptInt("Age: ");

            var weight = PromptFloat("Weight (kg): ");

            var height = PromptFloat("Height (cm): ");


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


    }
}
