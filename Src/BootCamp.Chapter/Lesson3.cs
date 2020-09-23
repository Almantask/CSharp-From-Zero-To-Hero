using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {            
            CallFunctions("Person 1");
            CallFunctions("Person 2");
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        public static string PromptString(string message)
        {
            Console.Write(message);
            string text = Console.ReadLine();
            return text;
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            float number = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            return number;
        }
        public static float CalculateBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }
        public static void CallFunctions(string person)
        {
            Console.WriteLine(person);
            string name = PromptString("Enter your name: ");
            string surname = PromptString("Enter your surname: ");
            int age = PromptInt("Enter your age: ");
            float height = PromptFloat("Enter your height: ");
            float weight = PromptFloat("Enter your weight: ");
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine($"Your BMI is: {bmi}");
        }
    }
}
