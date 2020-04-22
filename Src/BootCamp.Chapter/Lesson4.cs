using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson4
    {
        public static void Demo()
        {
            ProcessPersonBMI();
            ProcessPersonBMI();
        }
        public const int InvalidInt = -1;
        public const string InvalidString = "-";
        public const float InvalidFloat = -1;
        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            bool ValidInt;
            if (String.IsNullOrEmpty(input)) return 0;
            ValidInt = int.TryParse(input, out var number);
            if (!ValidInt || number < 0)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return InvalidInt;
            }
            return number;
        }

        public static string PromptString(string message)
        {
                Console.Write(message);
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.Write("Name cannot be empty.");
                    return InvalidString;
                }
                return input;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return 0;
            bool ValidFloat = float.TryParse(input, out var bmiInfo);
            if (!ValidFloat)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return InvalidFloat;
            }
            return bmiInfo;
        }

        public static float CalculateBmi(float weightkg, float heightcm)
        {
            if (weightkg <= 0 && heightcm <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:" + Environment.NewLine);
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightkg}.");
                Console.WriteLine($"Height cannot be less than zero, but was {heightcm}.");
                return InvalidFloat;
            }
            else if (weightkg <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:" + Environment.NewLine);
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightkg}.");
                return InvalidFloat;
            }
            else if (heightcm <= 0)
            {
                Console.Write("Failed calculating BMI. Reason:" + Environment.NewLine);
                Console.WriteLine($"Height cannot be equal or less than zero, but was {heightcm}.");
                return InvalidFloat;
            }
            float bmi = weightkg / heightcm / heightcm;
            return bmi;
        }

        public static void ProcessPersonBMI()
        {
            string name = PromptString("Enter your Name: ");
            string surname = PromptString("Enter your Surname: ");
            int age = PromptInt("Enter your age: ");
            float weightkg = PromptFloat("Enter your weight(kg): ");
            float heightcm = PromptFloat("Enter your height(cm): ");
            float heightm = heightcm / 100;
            float bmi = CalculateBmi(weightkg, heightm); 
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weightkg + " kg and his height is " + heightcm + " cm. His BMI is " + bmi);
            Console.WriteLine();
        }
    }
}