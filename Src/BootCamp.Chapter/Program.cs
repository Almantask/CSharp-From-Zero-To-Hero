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
            //Ask for whole name
            string name = WholeName(message: "Input your name: ");
            string surname = WholeName(message: "Input your surname: ");


            //Ask for height and weight
            float height = HeightAndWeight(message: "Input your height in meters: ");
            float weight = HeightAndWeight(message: "Input your weight in kg: ");

         


        }


        public static string WholeName (string message)
        {
            Console.WriteLine(message);
            string partOfName= Console.ReadLine();

            return partOfName;
        }

        public static float HeightAndWeight (string message)
        {
            Console.WriteLine(message);
            float value = parse.Float.Console.ReadLine();

            return value;
        }

        public static float CalculateBMI()
        {

        }
    }
}
