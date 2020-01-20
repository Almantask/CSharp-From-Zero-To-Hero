using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string askAgain;
            int age;
            int weight;
            int height;
            

            do
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("How tall are you in inches?");
                height = int.Parse(Console.ReadLine());
                Console.WriteLine("How much do you weight in pounds?");
                weight = int.Parse(Console.ReadLine());
                
                float calculateBMI = 703 * weight / (height * height);

                Console.WriteLine($"{name} is {age} years old, weighs {weight} pounds and is {height} inches tall. \nWith a weight of {weight} pounds and height of {height} inches, {name} has a BMI of {calculateBMI}.");

                
                Console.WriteLine("\nWould you like the check the BMI of someone else? (y/n)");
                askAgain = Console.ReadLine().ToLower();
                    while (askAgain != "n" && askAgain != "y")
                    {
                        Console.WriteLine($"Invalid answer; you entered {askAgain} please enter y or n.");
                        askAgain = Console.ReadLine();
                    }
                
            } while (askAgain == "y");

            





        }
    }
}
