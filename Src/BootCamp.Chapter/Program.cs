using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    public class Program
    {
        private static string message;

        public static void Main(string[] args)
        {
        }
        public static string ReadName(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            return name;
        }
        public static int ReadAge(string message)
        {
            Console.WriteLine(message);
            string age = Console.ReadLine();
            int realAge = int.Parse(age);
            return realAge;
        }
        public static float ReadWeight(string message)
        {
            Console.WriteLine(message);
            string weight = Console.ReadLine();
            float weightInKilograms = float.Parse(weight);
            return weightInKilograms;
        }
        public static float ReadHeight(string message)
        {
            Console.WriteLine(message);
            string height = Console.ReadLine();
            float heightInCentemeters = float.Parse(height);
            return heightInCentemeters;
        }
        public static float CalculateBMI(float weight, float height)
        {
            weight = ReadWeight(message);
            height = ReadHeight(message);

            float heightInMeters = height / 100;
            float BMI = weight / (heightInMeters * heightInMeters);
            return BMI;
        }


    }
}
