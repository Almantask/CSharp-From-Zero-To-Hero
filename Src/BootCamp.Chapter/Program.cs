using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter your given name: ");
                string givenName = Console.ReadLine();
                Console.Write("Enter your surname: ");
                string surname = Console.ReadLine();
                Console.Write("Enter your age: ");
                short age = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter your weight (kg): ");
                short weight = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter your height (cm): ");
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = Math.Round(weight / height * 100, 2);

                Console.WriteLine("\n" + givenName + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.\nTheir BMI is " + bmi + ".\n");

                if (i == 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
