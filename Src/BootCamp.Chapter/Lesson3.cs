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
            string name = PromptName("Please provide your name: ");
            int age = PromptAge("Please provide your age: ");
            float weight = PromptWeight("Please provide your weigth in kg: ");
            float height = PromptHeight("Please provide your height in m: ");

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine("Their BMI is: " + bmi);
        }


        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                string heightErrorAddition = "equal or ";
                if (weight <= 0)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + '.');
                    heightErrorAddition = "";
                }
                if (height <= 0)
                {
                    Console.WriteLine("Height cannot be " + heightErrorAddition + "less than zero, but was " + height + '.');
                }
                return -1;
            }

            float bmi = weight / (height * height);
            return bmi;
        }

        public static int PromptAge(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int age);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if (age <= 0)
            {
                return 0;
            }

            return age;
        }

        public static string PromptName(string message)
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

        public static float PromptWeight(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float weight);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine("Height cannot be equal or less than zero, but was " + weight + ".");
                return 0;
            }

            return weight;
        }

        public static float PromptHeight(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float height);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return 0;
            }

            return height;
        }
    }
}
