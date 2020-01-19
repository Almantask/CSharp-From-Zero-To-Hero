using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator ");
            Console.WriteLine("Hello, what's the name of the person that you want to calculate the BMI? ");
            string name = Console.ReadLine();
            
            Console.WriteLine("What's the surename? ");
            string surename = Console.ReadLine();
            
            Console.WriteLine("What's the Age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What's the height? ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What's the weight? ");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            
            double bmi = (weight / ((height / 100.0) * (height / 100.0)));

            Console.WriteLine(name + " " + surename + " BMI is " + bmi);
            Console.ReadLine();
            
            Console.WriteLine("BMI Calculator ");
            Console.WriteLine("Hello, what's the name of the person that you want to calculate the BMI? ");
            name = Console.ReadLine();

            Console.WriteLine("What's the surename? ");
            surename = Console.ReadLine();

            Console.WriteLine("What's the Age? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the height? ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's the weight? ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            bmi = (weight / ((height / 100.0) * (height / 100.0)));

            Console.WriteLine(name + " " + surename + " BMI is " + bmi);
            Console.ReadLine();
        }
    }
}
