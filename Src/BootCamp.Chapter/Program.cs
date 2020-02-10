using System;

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = PromptString("name");
            string surname = PromptString("surname");
            int age = PromptInt("age");
            int weight = PromptInt("weight");
            double height = PromptFloat("height");
            double bmi = CalculateBmi(weight,height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm. His BMI is {bmi}.");
        }
        public static string PromptString(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            return Console.ReadLine();
        }
        public static int PromptInt(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double PromptFloat(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            return Convert.ToSingle(Console.ReadLine());
        }

        public static double CalculateBmi(double weight, double height)
        {
            return weight/ height*height;
        }
    }
}
