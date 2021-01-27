using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Lesson4
    {
        const int integerError = -1;
        const float floatError = -1.0f;
        const string stringError = "-";

        public static void Demo()
        {
            string name = PromptString("Name: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight(kg): ");
            float height = PromptFloat("Height(cm): ");

            float bmi = CalculateBMI(weight, (height/100)); //convert cm to m
           
            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"BMI is: {bmi:0.00}");
        }

        public static string PromptString(string message)
        {
            string variable;
            Console.WriteLine(message);
            variable = Console.ReadLine();

            //Validate string input
            if(!String.IsNullOrEmpty(variable))
            {
                return variable;
            }

            Console.WriteLine("Name cannot be empty.");
            return stringError;
        }

        public static int PromptInt(string message)
        {
            string variable;
            Console.WriteLine(message);
            variable = Console.ReadLine();

            //Validate integer input
            if (int.TryParse(variable, out int num))
            {
                return num;
            }
           
            Console.WriteLine($"\"{variable}\" is not a valid number.");
            return integerError;
        }

        public static float PromptFloat(string message)
        {
            string variable;
            Console.WriteLine(message);
            variable = Console.ReadLine();

            //Validate float input
            if (float.TryParse(variable, out float num))
            {
                return num;
            }

            Console.WriteLine($"\"{variable}\" is not a valid number.");
            return floatError;
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi;

            //Checks if weight and height are greater than 0 and
            //calculates BMI
            if (weight > 0 && height > 0)
            {
                bmi = weight / (height * height);
                return bmi;
            }

            //Error messages
            Console.WriteLine($"Failed calculating BMI. Reason:");
            if (weight <= 0)
            {
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}");
            }
            if (height <= 0)
            {
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}");
            }
            return floatError;
        }
    }
}
