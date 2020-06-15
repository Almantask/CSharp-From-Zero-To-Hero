using System;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            var name = PromptString("Name: ");
            var age = PromptInt("Age: ");
            var weight = PromptFloat("Weight in kg: ");
            var height = PromptFloat("Height in m: ");
            var bmi = CalculateBmi(weight, height);

            Console.WriteLine($"So to get this correct {name}, you are {age} years old, weighing {weight}kg, standing at {height}meters.");
            Console.WriteLine($"If the above information is true, your BMI is {bmi}.");
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message) {
            Console.Write(message);
            return float.Parse(Console.ReadLine());
        }

        public static string PromptString(string message) {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float CalculateBmi(float weight, float height) { 
            return weight / (height * height);
        }
    }
}
