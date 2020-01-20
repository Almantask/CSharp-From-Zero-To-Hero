using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your weight(kg): ");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter your height(cm): ");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            float BMI = weight / Convert.ToSingle(Math.Pow(height / 100, 2));

            Console.WriteLine("Your BMI is " + BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("You are Underweight.");
            } 
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("You have a Normal Weight.");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("You are Overweight.");
            }
            else if (BMI >= 30)
            {
                Console.WriteLine("You are Obese.");
            }
            else
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }

        }
    }
}
