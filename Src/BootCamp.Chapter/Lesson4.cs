using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = promptString("Please enter your name:");
            int age = promptInt("Please tell me how old you are:");
            int weight = promptInt("What is your weight?");
            float height = promptInt("What is your height?");

            float bmi = calculateBmi(weight, height) * 10000;

            Console.WriteLine($"Welcome {name}, you are {age} years old and have a BMI of {bmi:F2}.");
        }

        public static float calculateBmi(float weight, float height)
        {
            if (weight <= 0)
            {
                Console.WriteLine($"Failed calculating BMI.Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            if (height <= 0)
            {
                Console.WriteLine($"Failed calculating BMI.Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return -1;
            }
            float bmi = weight / (height * height);
            return bmi;
        }

        public static int promptInt(string message)
        {
            Console.WriteLine(message);
            int number;

            string input = Console.ReadLine();
            bool succes = int.TryParse(input, out number);
            if (!succes)
            {
                Console.WriteLine($"{input} is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }
            
        }

        public static string promptString(string message)
        {
            Console.WriteLine(message);
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            else
            {
                return name;
            }
        }

        public static float promptFloat(string message)
        {
            Console.WriteLine(message);
            float number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}