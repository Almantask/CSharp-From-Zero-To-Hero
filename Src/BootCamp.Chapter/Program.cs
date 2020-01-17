using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double height, bmi, weight;
            string name, surename;

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

            int age2;
            double height2, bmi2, weight2;
            string name2, surename2;

            Console.WriteLine("BMI Calculator ");
            Console.WriteLine("Hello, what's the name of the person that you want to calculate the BMI? ");
            name2 = Console.ReadLine();

            Console.WriteLine("What's the surename? ");
            surename2 = Console.ReadLine();

            Console.WriteLine("What's the Age? ");
            age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the height? ");
            height2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's the weight? ");
            weight2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(name2 + " " + surename2 + " is " + age2 + " years old, his weight is " + weight2 + " kg and his height is " + height2 + " cm.");

            bmi2 = (weight2 / ((height2 / 100.0) * (height2 / 100.0)));

            Console.WriteLine(name2 + " " + surename2 + " BMI is " + bmi2);
            Console.ReadLine();
        }
    }
}
