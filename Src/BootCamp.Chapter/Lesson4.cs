using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string name = GetString("What's your first name?");
            string surname = GetString("What's your surname?");
            int age = GetInt("How old are you?");
            float weight = GetFloat("How much do you weight in kg?");
            float height = GetFloat("How tall are you in cm?");
            float mHeight = ConvertToMetres(height);
            float bodyMassIndex = CalculateBMI(mHeight, weight);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + " cm");

            Console.WriteLine("Their BMI is: " + bodyMassIndex);

            string friendName = GetString("\nWhat's your friend's first name?");
            string friendSurname = GetString("What's their surname?");
            int friendAge = GetInt("How old are they?");
            float friendWeight = GetFloat("How much do they weight in kg?");
            float friendHeight = GetFloat("How tall are they in cm?");
            float friendMHeight = ConvertToMetres(friendHeight);
            float friendBodyMassIndex = CalculateBMI(friendMHeight, friendWeight);

            Console.WriteLine(friendName + " " + friendSurname + " is " + friendAge + " years old, his weight is " + friendWeight + "kg and his height is " + friendHeight + " cm");

            Console.WriteLine("Their BMI is: " + friendBodyMassIndex);
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();

            if (string.IsNullOrEmpty(response))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }

            return response;
        }

        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            if (!isNumber)
                return -1;

            return number;
        }

        public static float GetFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);

            if (!isNumber) return -1;

            return number;
        }

        public static float CalculateBMI(float height, float weight)
        {
            return weight / (height * height);
        }

        private static float ConvertToMetres(float height)
        {
            return height / 100;
        }

    }
}
