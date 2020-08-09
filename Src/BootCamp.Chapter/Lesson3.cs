using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    static class Lesson3
    {
        public static void Demo()
        {
            string name = Checks.PromptString("Enter name: ");
            string surname = Checks.PromptString("Enter surname: ");
            int age = Checks.PromptInt("Enter age: ");
            float weight = Checks.PromptFloat("Enter weight in kg: ");
            float height = Checks.PromptFloat("Enter height in cm: ");
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            float bmi = Checks.CalculateBmi(weight, height) * 10000;
            Console.WriteLine($"{name}'s BMI: {bmi}");

            name = Checks.PromptString("Enter name: ");
            surname = Checks.PromptString("Enter surname: ");
            age = Checks.PromptInt("Enter age: ");
            weight = Checks.PromptFloat("Enter weight in kg: ");
            height = Checks.PromptFloat("Enter height in cm: ");
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            bmi = Checks.CalculateBmi(weight, height) * 10000;
            Console.WriteLine($"{name}'s BMI: {bmi}");
        }
    }
}
