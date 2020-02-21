using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.Write("Hello, input your name: ");
                var name = Console.ReadLine();
                Console.Write("Now input your surname: ");
                var surname = Console.ReadLine();
                Console.WriteLine("Now you will be asked to input your age, weight in kg and height in cm.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Age: ");
                Console.ResetColor();
                var age = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Weight: ");
                Console.ResetColor();
                var weight = Convert.ToDouble(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Height: ");
                Console.ResetColor();
                var height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hello, " + name + " " + surname + ". " + "I can see You are " + age + " years old and your height is " + height + " cm and you weigh " + weight + " kg.");

                double bmi = weight / ((height / 100.0) * (height / 100.0));

                Console.WriteLine("Your BMI is : " + Math.Round(bmi, 2));
                if (bmi < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You're underweight.");
                    Console.ResetColor();
                }
                else if (bmi > 18.5 && bmi < 24)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You're normal weight.");
                    Console.ResetColor();
                }

                else if (bmi > 23)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're Overweight.");
                    Console.ResetColor();
                }

                Console.WriteLine("Do you want to calculate BMI again? Y/N");
                input = Console.ReadLine();
            } while (input == "y" || input == "Y");
        }
    }
}
