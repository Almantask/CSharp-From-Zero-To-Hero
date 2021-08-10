using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = AskFullName();
            int age = AskAge();
            int weight = AskWeight();
            double height = AskHeight();

            Console.WriteLine($"{fullName} is {age} years old, his weight is {weight} kg and his height is {height:F1} cm.");

            CalculateBmi(weight, height);
        }

        static string AskFullName()
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your family name?");
            string surname = Console.ReadLine();

            return firstname + " " + surname;
        }

        static int AskAge()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        static int AskWeight()
        {
            Console.WriteLine("How much do you weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());

            return weight;
        }

        static double AskHeight()
        {
            Console.WriteLine("How tall are you?");
            double height = Convert.ToDouble(Console.ReadLine());

            return height;
        }

        static void CalculateBmi(int weight, double height)
        {
            double bmi = (weight / (height * height) * 10000);

            Console.WriteLine($"Your BMI is {bmi:F1}");
        }
    }
}
