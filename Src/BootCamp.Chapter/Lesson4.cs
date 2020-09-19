using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello first person, what's your first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("What's your second name?");
                string secondName = Console.ReadLine();
                Console.WriteLine("What's your age?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("What's your weight? (In kg)");
                float weight = float.Parse(Console.ReadLine());
                Console.WriteLine("What's your height? (In cm)");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine(firstName + " " + secondName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
                Console.WriteLine("Your body-mass index (BMI) is: " + (weight / ((height / 100) * (height / 100))));
            }
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber && !string.IsNullOrEmpty(input))
            {
                Console.Write("{input} is not a valid number.");
                return -1;
            }
            return number;
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return input;
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);

            if (!isNumber && !string.IsNullOrEmpty(input))
            {
                Console.Write("{input} is not a valid number.");
                return -1;
            }
            return number;
        }
        public static float CalculateBmi(float weight, float height)
        {
            bool isValidWeight = true;
            bool isValidHeight = true;

            if (weight <= 0)
                isValidWeight = false;
            if (height <= 0)
                isValidHeight = false;

            if (!isValidHeight || !isValidWeight)
            { 
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (!isValidHeight)
                    Console.Write(" Height cannot be equal or less than zero, but was {height}.");
                if (!isValidWeight)
                    Console.Write(" Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            return (weight / height / height);
        }
    }
}
