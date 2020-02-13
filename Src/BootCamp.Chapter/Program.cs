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
            double bmi = CalculateBmi(weight, height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");
            if (bmi > 0)
            {
                Console.WriteLine($"His BMI is {bmi}.");
            }
        }
        public static string PromptString(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Name cannot be empty.");
                    return "-";
            }
            else
            {
                return input;
            }
        }
        public static int PromptInt(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            int intnum;
            var input = Console.ReadLine();
            bool isInt = int.TryParse(input, out intnum);
            if (!isInt)
            {
                Console.WriteLine($"{input} is not a valid entry.");
                return -1;
            }
            else if (input == "")
            {
                return 0;
            }
            else
            {
                return intnum;
            }
        }

        public static double PromptFloat(string attribute)
        {
            Console.Write($"What is your {attribute}? ");
            double doubnum;
            string input = Console.ReadLine();
            bool isDoub = double.TryParse(input, out doubnum);
            if (!isDoub)
            {
                Console.WriteLine($"{input} is not a valid entry.");
                return -1;
            }
            else
            {
                return doubnum;
            }
        }

        public static double CalculateBmi(double weight, double height)
        {
            if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                if (weight > 0)
                {
                    return 0;
                }
                }
            if (weight <= 0)
                {
                    Console.WriteLine($"Height cannot be less than zero, but was {weight}.");
                    return 0;
                }
            else
                {
                    return weight / height * height;
                }
        }
    }
}
