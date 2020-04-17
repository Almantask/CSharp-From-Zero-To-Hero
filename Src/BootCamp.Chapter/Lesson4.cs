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
            float finalBmi = CalculateBmi(DemoHeight, DemoWeight);

            Console.WriteLine("-------------------");
            Console.WriteLine(firstName + " " + lastName + " is " + Age + " years old.");
            Console.WriteLine("His weight is " + demoWeight + "kg and his height is " + (demoHeight / 100) + " meters.");
            Console.WriteLine("Their BMI is: " + finalBmi);
            Console.WriteLine("-------------------");
        }
        public static float CalculateBmi(float weight, float height)
        {
            var Bmi = weight / height / height;
            //if needing pounds, use inches instead of cm
            //var BmiPounds = (Weight / Height / Height) * 703;
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
