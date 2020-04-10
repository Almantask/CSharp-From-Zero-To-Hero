using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
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
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
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
