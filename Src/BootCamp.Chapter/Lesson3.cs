using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            PromptPersonInformation("1");

            PromptPersonInformation("2");
        }

        private static void PromptPersonInformation(string person)
        {
            Console.WriteLine("Person " + person + ":");
            string name = PromptStringInput("Please provide your name: ");
            string surname = PromptStringInput("Please provide your surname: ");
            int age = PromptIntInput("Please provide your age: ");
            int weight = PromptIntInput("Please provide your weigth in kg: ");
            float height = PromptFloatInput("Please provide your height in m: ");

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine("Their BMI is: " + bmi);
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }

            float bmi = weight / (height * height);
            return bmi;
        }

        public static int PromptIntInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if (number == 0)
            {
                return 0;
            }

            return number;
        }

        public static string PromptStringInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return input;
        }

        public static float PromptFloatInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if (number == 0)
            {
                return 0;
            }

            return number;
        }
    }
}
