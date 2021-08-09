using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = askFullName();
            int age = askAge();
            int weight = askWeight();
            double height = askHeight();

            Console.WriteLine($"{fullName} is {age} years old, his weight is {weight} kg and his height is {height:F1} cm.");

            CalculateBMI(weight, height);
        }

        static string askFullName()
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your family name?");
            string surname = Console.ReadLine();

            return firstname + " " + surname;
        }

        static int askAge()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        static int askWeight()
        {
            Console.WriteLine("How much do you weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());

            return weight;
        }

        static double askHeight()
        {
            Console.WriteLine("How tall are you?");
            double height = Convert.ToDouble(Console.ReadLine());

            return height;
        }

        static void CalculateBMI(int weight, double height)
        {
            double bmi = (weight / (height * height) * 10000);

            Console.WriteLine($"Your BMI is {bmi:F1}");
        }
    }
}
