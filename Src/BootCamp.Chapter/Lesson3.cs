using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            ProcessPersonInfo();
            ProcessPersonInfo();
        }

        public static void ProcessPersonInfo()
        {
            string name = PromptString("Name: ");
            int age = PromptInt("Age: ");
            float weightKg = PromptFloat("Weight in kg: ");
            float heightM = PromptFloat("Height in metres: ");
            float bmi = CalculateBmi(weightKg, heightM);

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weightKg + " kg and their height is " + heightM + " m.");
            Console.WriteLine(name + "'s BMI is " + bmi);
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return input;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out var age);

            if (string.IsNullOrEmpty(input)) return 0;

            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            if (age == 0)
            {
                Console.Write($"\"{input}\" is a number but 0.");
                return 0;
            }

            return Convert.ToInt32(age);
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float num);

            if (string.IsNullOrEmpty(input)) return 0;

            if (num <= 0)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            if (!isNumber) return -1;


            return num;
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            bool isWeight = true;
            bool isHeight = true;
            if (weightKg <= 0) isWeight = false;
            if (heightM <= 0) isHeight = false;
            if (!isWeight)
            {
                if (!isHeight)
                {
                    Console.WriteLine("Failed calculating BMI. Reason:");
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightKg}.");
                    Console.WriteLine($"Height cannot be less than zero, but was {heightM}.");
                    return -1;
                }

                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightKg}.");
                return -1;
            }
            else if (!isHeight)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {heightM}.");
                return -1;
            }
            
            float bmi = weightKg / (heightM * heightM);
            return bmi;
        }
    }
}
