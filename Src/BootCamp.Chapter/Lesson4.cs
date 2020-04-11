using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = PromptString("What's your first name?");
            string surname = PromptString("What's your surname?");
            int age = PromptInt("How old are you?");
            float weight = PromptFloat("How much do you weight in kg?");
            float height = PromptFloat("How tall are you in cm?");
            float mHeight = ConvertToMetres(height);
            float bodyMassIndex = CalculateBMI(mHeight, weight);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + " cm");

            Console.WriteLine("Their BMI is: " + bodyMassIndex);

            string friendName = PromptString("\nWhat's your friend's first name?");
            string friendSurname = PromptString("What's their surname?");
            int friendAge = PromptInt("How old are they?");
            float friendWeight = PromptFloat("How much do they weight in kg?");
            float friendHeight = PromptFloat("How tall are they in cm?");
            float friendMHeight = ConvertToMetres(friendHeight);
            float friendBodyMassIndex = CalculateBMI(friendMHeight, friendWeight);

            Console.WriteLine(friendName + " " + friendSurname + " is " + friendAge + " years old, his weight is " + friendWeight + "kg and his height is " + friendHeight + " cm");

            Console.WriteLine("Their BMI is: " + friendBodyMassIndex);
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();

            if (string.IsNullOrEmpty(response))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return response;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);


            if (string.IsNullOrEmpty(input))
                return 0;
            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);

            if (string.IsNullOrEmpty(input)) 
                return 0;
            if (!isNumber)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static float CalculateBMI(float height, float weight)
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

            return weight / (height * height);
        }

        private static float ConvertToMetres(float height)
        {
            return height / 100;
        }

    }
}
