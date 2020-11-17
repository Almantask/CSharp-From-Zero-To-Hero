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
            // Variables
            string nameSurname = " ";
            int age = 0;
            float weight = 0;
            float height = 0;

            // Return Functions
            nameSurname = Lesson3.PromptString("Enter your name");
            age = Lesson3.PromptInt("Enter your age");
            weight = Lesson3.PromptFloat("Enter your weight in Kg");
            height = Lesson3.PromptFloat("Enter your height in m");

            Console.WriteLine(nameSurname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m");

            // BMI Function
            Lesson3.CalculateBmi(weight, height);

        }
    }
}
