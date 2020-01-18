using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("What is your First Name?");
                string firstName = Console.ReadLine();

                Console.WriteLine("\nWhat is your Last Name?");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nWhate is your age?");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nWhate is your weight(kg)?");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nWhate is your height(cm)?");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n" + firstName + " " + lastName + " is a " + age + " year old, their weight is " +
                    weight + " kg and their height is " + height + " cm.");


                double heightInMeters = height * .01;
                double bmi = weight / (heightInMeters * heightInMeters);

                Console.WriteLine("Their Body-Mass Index (BMI) is " + bmi + "\n");
            }
        }
    }
}
