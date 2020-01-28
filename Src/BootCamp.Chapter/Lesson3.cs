using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            NewPerson();
        }

        public static void NewPerson()
        {
            string fName = PromptString("Enter first name:");

            string lName = PromptString("Enter last name:");

            int age = PromptInt("Enter age:");

            float weight = PromptFloat("Enter wight in kg:");

            float height = PromptFloat("Enter height in cm:");

            Console.WriteLine($"{fName} {lName} is {age} years old, their weight is {weight} kg and their height is {height} cm.");

            Console.WriteLine($"{fName} {lName}'s BMI is " + BMIConversion(weight, height));
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

        public static float BMIConversion(float weight, float height)
        {
            return weight / ((height / 100) * (height / 100));
        }
    }
}
