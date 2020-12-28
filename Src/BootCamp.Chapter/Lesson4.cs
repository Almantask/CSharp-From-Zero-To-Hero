using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = Checks.PromptString("NAME: ");
            string surName = Checks.PromptString("SURNAME: ");
            int age = Checks.PromptInt("AGE: ");
            float weight = Checks.PromptFloat("WEIGHT(kg): ");
            float height = Checks.PromptFloat("HEIGHT(cm): ");
            float Bmi = Checks.CalculateBmi(weight, height);
            
            Console.WriteLine("----------------------------------------- Your Results -----------------------------");
            
            if (Bmi == (-1) || age == (-1) || name == "-" || surName == "-")
                Console.WriteLine("ERROR calculating BMI, please try again.");
            else
            {
                Console.WriteLine($"{name} {surName} you are {age} years old, your weight is {weight} Kg, and your height is {height} cm.");
                Console.WriteLine($"Your BMI is {Bmi}.");
                Console.WriteLine("------------------------------------------------------------------------------------");
            }

        }
    }
}