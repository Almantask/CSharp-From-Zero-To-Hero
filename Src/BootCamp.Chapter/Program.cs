using System;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                var surname = Lesson3.PromptString("Please enter your surname: ");
                var age = Lesson3.PromptInt("Please enter your age: ");
                var weight = Lesson3.PromptFloat("Please enter your weight (in kg): ");
                var height = Lesson3.PromptFloat("Please enter your height (in m): ");
                Console.WriteLine(surname + " is " + age + " " + "years old, his weight is " + weight + "kg and his height is " + height + "m.");
                
                var Bmi = Lesson3.CalculateBmi(weight, height);
                Console.WriteLine("Your estimated BMI is " + Bmi);
            }
        }
    }
}

