using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lession3
    {
        public static void Demo()
        {
            Console.WriteLine("BMI Calculator v2 by Joseph Cerdan");

            //Read inputs from user
            string name = readName();
            string surname = readSurname();
            int age = readAge();
            float height = readHeight();
            float weight = readWeight();
            
            //Display information
            Console.WriteLine(name + " " + surname + " is " + 
                age + " years old, their weight is " + weight + 
                " kg and their height is " + height + " m."); 

            //Calculate and display BMI
            calculateBMI(weight, height);
        }

        private static string readName()
        {
            return Checks.PromptString("Name: ");
        }

        private static string readSurname()
        {
            return Checks.PromptString("Surname: ");
        }

        private static int readAge()
        {
            return Checks.PromptInt("Age: ");
        }

        private static float readHeight()
        {
            return Checks.PromptFloat("Height (m): ");
        }

        private static float readWeight()
        {
            return Checks.PromptFloat("Weight (kg): ");
        }

        private static void calculateBMI(float weight, float height)
        {
            Console.WriteLine("BMI is: " + Checks.CalculateBmi(weight, height));
        }
    }
}
