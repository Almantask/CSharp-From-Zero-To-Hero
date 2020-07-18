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
            float bmi;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your weight (kg): ");
            weight = int.Parse(Console.ReadLine());

            Console.Write("Enter your height (cm): ");
            height = float.Parse(Console.ReadLine());

            bmi = (float) (weight / Math.Pow((height / 100.0), 2));

            Console.WriteLine("\n" + firstName + " " + lastName + " is " + age + " years old, " +
                              "his weight is " + weight + " kg " +
                              "and his height is " + height + " cm.\n");
            Console.WriteLine(firstName + "'s BMI is " + bmi);
        }
    }
}
