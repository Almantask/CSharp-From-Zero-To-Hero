using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson_4
    {
        public static void Demo()
        {
            string name = Checks.PromptString("Enter your name: ");
            int age = Checks.PromptInt("Enter your age: ");
            float weight = Checks.PromptFloat("Enter your weight,unit is kg: ");
            float height = Checks.PromptFloat("Enter your height,unit is meters: ");

            float bmi = Checks.CalculateBmi(weight, height);
            if (bmi == (-1) || age == (-1) || name == "-")
                Console.WriteLine("Input error, please check again.");
            else
            {
                Console.WriteLine($"{name} is {age} years old, weight is {weight} kg, height is {height} meters, BMI is {bmi}");
            }
        }
    }
}
