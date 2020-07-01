using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            string name = PromptString("Enter name: ");
            int age = PromptInt("Enter age: ");
            float weight = PrompFloat("Enter weight: ");
            float height = PrompFloat("Enter height in m: ");

            PrintFullMessage(name, age, weight, height);
        }

        public static void PrintFullMessage(string name, int age, float weight, float height)
        {
            Console.WriteLine("You have entered:");
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("BMI: " + CalculateBMI(weight, height));
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string readString = Console.ReadLine();
            string emptyString = "-";
            if (String.IsNullOrEmpty(readString))
            {
                Console.Write("Name cannot be empty.");
                return emptyString;
            }
            return readString;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isNumber = int.TryParse(input, out var readInt);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isNumber)
            {
                Console.Write((char)34 + input + (char)34 + " is not a valid number.");
                return -1;
            }
            else
            {
                return readInt;
            }
        }

        public static float PrompFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isNumber = float.TryParse(input, out var readFloat);
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (!isNumber)
            {
                Console.Write((char)34 + input + (char)34 + " is not a valid number.");
                return -1;
            }
            return readFloat;
        }

        public static void PrintWeightErrorMessage(float weight)
        {
            Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
        }
        public static void PrintHeightErrorMessage(float height, string errorMessage)
        {
            Console.WriteLine("Height cannot be " + errorMessage + "less than zero, but was " + height + ".");
        }
        public static float CalculateBMI(float weight, float height)
        {
            string fullErrorMessage = "equal or ";
            string errorMessage = null;

            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                PrintWeightErrorMessage(weight);
                PrintHeightErrorMessage(height, errorMessage);
                return -1;
            }
            else if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (weight <= 0)
                {
                    PrintWeightErrorMessage(weight);
                    return -1;
                }
                if (height <= 0)
                {
                    PrintHeightErrorMessage(height, fullErrorMessage);
                    return -1;
                }
            }
            float BMI = weight / (height * height);
            return BMI;
        }
    }
}