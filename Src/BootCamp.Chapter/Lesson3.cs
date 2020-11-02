using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = Checks.PromptString("Please enter your name: ");
            int age = Checks.PromptInt("Please enter your age: ");
            float weight = Checks.PromptFloat("Please enter your weight,unit is kg: ");
            float height = Checks.PromptFloat("please enter your height,unit is meters: ");
            float bmi = Checks.CalculateBmi(weight, height);
            Console.WriteLine($"{name} is {age} years old, weight is {weight} kg, height is {height} meters, BMI is {bmi}");

        }
    }
}
