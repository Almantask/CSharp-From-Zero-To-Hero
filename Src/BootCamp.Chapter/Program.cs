using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string askAgain;
            do
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("How tall are you in inches?");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("How much do you weight in pounds?");
                float weight = float.Parse(Console.ReadLine());
                
                float calculateBMI = 703f * weight / (height * height);

                Console.WriteLine($"{name} is {age} years old, weighs {weight} pounds and is {height} inches tall. ");
                Console.WriteLine($"\nWith a weight of {weight} pounds and height of {height} inches, {name} has a BMI of {calculateBMI}.");

                
                Console.WriteLine("\nWould you like the check the BMI of someone else? (y/n)");
                askAgain = Console.ReadLine().ToLower(CultureInfo.InvariantCulture);
                    while (askAgain != "n" && askAgain != "y")
                    {
                        Console.WriteLine($"Invalid answer; you entered {askAgain} please enter y or n.");
                        askAgain = Console.ReadLine();
                    }
                
            } while (askAgain == "y");

            





        }
    }
}
