using System;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            static void bmiCalculator() {
                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();

                Console.WriteLine("What is your age?");
                var age = Console.ReadLine();

                Console.WriteLine("What is your weight in kg");
                float weight = float.Parse(Console.ReadLine());

                Console.WriteLine("What is your height in cm");
                float height = float.Parse(Console.ReadLine());

                float mSquared = (height / 100) * (height / 100);
                float bmi = weight / mSquared;

                Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

                Console.WriteLine("BMI = " + bmi);
            }

            bmiCalculator();

            Console.WriteLine("Do you want to continue? Y/N");
            var answer = Console.ReadLine();
            if (answer == "Y")
            {
                bmiCalculator();
            }
            else
            {
                Console.WriteLine("The End");
            }
        }
    }
}
