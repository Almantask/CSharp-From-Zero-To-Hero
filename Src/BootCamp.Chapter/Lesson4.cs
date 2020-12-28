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
            //string surName = Checks.PromptString("SURNAME: ");
            int age = Checks.PromptInt("AGE: ");
            float weightKg = Checks.PromptFloat("WEIGHT(kg): ");
            float heightM = Checks.PromptFloat("HEIGHT(m): ");
            float Bmi = Checks.CalculateBmi(weightKg, heightM);
            
            Console.WriteLine("----------------------------------------- Your Results -----------------------------");
            
            if (Bmi == (-1) || age == (-1) || name == "-")
                Console.WriteLine("ERROR calculating BMI, please try again.");
            else
            {
                Console.WriteLine($"{name} you are {age} years old, your weight is {weightKg} Kg, and your height is {heightM} m.");
                Console.WriteLine($"Your BMI is {Bmi}.");
                Console.WriteLine("------------------------------------------------------------------------------------");
            }

        }
    }
}

