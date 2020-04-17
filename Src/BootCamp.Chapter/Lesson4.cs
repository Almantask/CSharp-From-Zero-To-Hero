using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            var firstName = PromptString("What's your first name?");
            var lastName = PromptString("What's your last name?");
            int Age = PromptInt("How old are you?");
            float demoWeight = PromptFloat("How much do you weight in kilo's?");
            float demoHeight = PromptFloat("How tall are you in cm?");
            float finalBmi = CalculateBmi(demoHeight, demoWeight);

            Console.WriteLine("-------------------");
            Console.WriteLine(firstName + " " + lastName + " is " + Age + " years old.");
            Console.WriteLine("His weight is " + demoWeight + "kg and his height is " + (demoHeight / 100) + " meters.");
            Console.WriteLine("Their BMI is: " + finalBmi);
            Console.WriteLine("-------------------");
        }
        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                if (weight <= 0 && height <= 0)
                {
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                    return -1;
                }
                if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                                
                return -1;
            }

            var Bmi = weight / height / height;
            return Bmi;
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var intInput = Console.ReadLine();
            bool isNumber = int.TryParse(intInput, out int number);

            if (string.IsNullOrEmpty(intInput))
                 return 0;
            if (!isNumber)
            {
                Console.WriteLine($"{intInput} is not a valid number.");
                return -1;
            }
            
            return number;
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string validateString = Console.ReadLine();
            if (string.IsNullOrEmpty(validateString))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return validateString;
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var floatInput = Console.ReadLine();
            bool isNumber = float.TryParse(floatInput, out float number);

            if (string.IsNullOrEmpty(floatInput))
                return 0;
            if (!isNumber)
            {
                Console.WriteLine($"{floatInput} is not a valid number.");
                return -1;
            }
            return number;
        }
    }
}
