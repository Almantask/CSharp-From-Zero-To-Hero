using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = PromptString("name");
            string surname = PromptString("surname");
            int age = PromptInt("age");
            int weight = PromptInt("weight");
            double height = PromptFloat("height");
            double bmi = CalculateBMI(weight,height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm. His BMI is {bmi}.");
        }
        static string PromptString(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            return Console.ReadLine();
        }
        static int PromptInt(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static double PromptFloat(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            return Convert.ToSingle(Console.ReadLine());
        }

        static double CalculateBMI(double weight, double height)
        {
            return weight/ height*height;
        }
    }
}
