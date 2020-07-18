using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int weight;
            float height;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your weight (kg): ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height (cm): ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("\n" + firstName + " " + lastName + " is " + age + " years old, " +
                              "his weight is " + weight + " kg " +
                              "and his height is " + height + " cm.");
        }
    }
}
