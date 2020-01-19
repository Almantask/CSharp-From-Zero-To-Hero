using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read name, surename, age, weight (in kg) and height (in cm) from console
            // calculate BMI index
            Console.WriteLine("Welcome to my homework. Please, type in your full name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Type in your age");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in your weight(kg)");
            double weight1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type in your height(cm)");
            double height1 = double.Parse(Console.ReadLine());
            double heightM1 = Math.Pow(height1 / 100.0, 2); //just to convert centimeters into meters, then ^2 them
            double bmi1 = weight1 / heightM1;
            
            Console.WriteLine("Now, type in another person's data. Please start with fullname");
            string name2 = Console.ReadLine();
            Console.WriteLine("Type in your age");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in your weight(kg)");
            double weight2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in your height(cm)");
            double height2 = double.Parse(Console.ReadLine());
            double heightM2 = Math.Pow(height2 / 100.0, 2); //just to convert centimeters into meters, then ^2 them
            double bmi2 = weight2 / heightM2;

            Console.WriteLine($"{name1} is {age1} years old, his weight is {weight1} kg and his height {height1} cm.");
            Console.WriteLine("His BMI index is: {0}", Math.Round(bmi1, 2));
            Console.WriteLine($"{name2} is {age2} years old, his weight is {weight2} kg and his height {height2} cm.");
            Console.WriteLine("His BMI index is: {0}", Math.Round(bmi2, 2));
        
            Console.ReadKey();
        }
    }
}
