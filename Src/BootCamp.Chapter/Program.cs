using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

//There should be as little duplicate code as possible(there should be functions for:
//- Calculating BMI (weight comes in kg, height comes in meters),
//- Prompt for input and converting it to int (print message for request, read console input and return converted input to int), 
//- Prompt for input and converting it to string (print message for request, read console input and return input),
//- Prompt for input and converting it to float (print message for request, read console input and return converted input to float).
//3) Put all the function you made into the right places in Checks.cs class. Run tests, make sure you pass all the tests
//4) Put all program.cs logic to Lesson3.cs.

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Checks.PromptString("Full name: ");
            Console.WriteLine();

            int age = Checks.PromptInt("Age: ");
            Console.WriteLine();

            float weight = Checks.PromptFloat("Weight: ");
            Console.WriteLine();
            
            float height = Checks.PromptFloat2("Height: ");
            Console.WriteLine();

            float bmi = Checks.CalculateBmi(weight, height);
            Console.WriteLine();

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + "kg and their height is " + height + " m. Their BMI is " + bmi + ".");

        }
    }
}
