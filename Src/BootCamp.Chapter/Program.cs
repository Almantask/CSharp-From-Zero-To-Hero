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
            string name = PromptString("Enter person´s name");
            string surename = PromptString("Enter person´s surename");
            int age = PromptInt("Enter person´s age");
            float weight = PromptFloat("Enter person´s weight in kg");
            float height = PromptFloat("Enter person´s height in m");
            Console.WriteLine($"{Environment.NewLine}{name} {surename} is {age}, weight is {weight} kg and height is {height} cm.");
            Console.WriteLine(CalculateBMI(weight, height));

            Console.WriteLine("");

            name = PromptString("Enter person´s name");
            surename = PromptString("Enter person´s surename");
            age = PromptInt("Enter person´s age");
            weight = PromptInt("Enter person´s weight in kg");
            height = PromptInt("Enter person´s height in cm");
            Console.WriteLine($"{Environment.NewLine}{name} {surename} is {age}, weight is {weight} kg and height is {height} cm.");
            Console.WriteLine($"BMI is {CalculateBMI(weight, height):f2}");

        }

        public static string PromptString(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int PromptInt(string text)
        {
            Console.WriteLine(text);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string text)
        {
            Console.WriteLine(text);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);            
        }
    }
}
