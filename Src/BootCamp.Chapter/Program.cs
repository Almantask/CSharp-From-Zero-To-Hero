using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptPersonalInfo();
            PromptPersonalInfo();
        }

        public static void PromptPersonalInfo()
        {
            //Ask for personal info
            string name = PromptString(message: "Input your name: ");
            string surname = PromptString(message: "Input your surname: ");
            int age = PromptInt(message: "Input your age: ");
            float height = PromptFloat(message: "Input your height in meters: ");
            float weight = PromptFloat(message: "Input your weight in kg: ");
            float bmi = CalculateBMI(weight: weight, height: height);

            Console.WriteLine(name + " " + surname + " " + "is" + " " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m and his/her BMI is: " + bmi);
        }

        public static string PromptString(string message)
        {
            //Input
            Console.WriteLine(message);
            string text = Console.ReadLine();

            //Check if the string is empty
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }

            return text;
        }

        public static float PromptFloat(string message)
        {
            //Input
            Console.WriteLine(message);
            string number = Console.ReadLine();

            //Check if the string is empty
            if (string.IsNullOrEmpty(number)) return 0;

            //Check if the string is a number
            if (!float.TryParse(number, out float floatNumber))
            {
                Console.WriteLine(number + " is not a valid number.");
                return -1;
            }

            return floatNumber;
        }

        public static int PromptInt(string message)
        {
            //Input
            Console.WriteLine(message);
            string number = Console.ReadLine();

            //Check if the string is empty
            if (string.IsNullOrEmpty(number)) return 0;

            //Check if the string is a number
            if (!int.TryParse(number, out var wholeNumber))
            {
                Console.WriteLine(number + " is not a valid number.");
                return -1;
            }

            return wholeNumber;
        }

        public static float CalculateBMI(float weight, float height)
        {
            string caseFail = "Failed calculating BMI. Reason: ";
            string case1 = "Height cannot be equal or less than zero, but was " + height + ".";
            string case2 = "Weight cannot be equal or less than zero, but was " + weight + ".";

            //Check if values are correct
            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine(caseFail);
                Console.WriteLine(case1);
                Console.WriteLine(case2);
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine(caseFail);
                Console.WriteLine(case1);
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine(caseFail);
                Console.WriteLine(case2);
                return -1;
            }

            float bmi = weight / (height * height);

            return bmi;
        }
    }
}
