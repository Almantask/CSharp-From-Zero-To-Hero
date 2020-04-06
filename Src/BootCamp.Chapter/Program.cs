using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1 and 2 
          
            string name;
            Console.WriteLine("What's your name ?");
            name = Console.ReadLine();

            string surename;
            Console.WriteLine("What's your name ?");
            surename = Console.ReadLine();

            int age;
            Console.WriteLine("What's your age ?");
            age = Convert.ToInt32(Console.ReadLine());

            double weight;
            Console.WriteLine("What's your weight (in kg) ?");
            weight = Convert.ToDouble(Console.ReadLine());

            double height;
            Console.WriteLine("What's your height (in cm) ?");
            height = Convert.ToDouble(Console.ReadLine());

            double heightMeters;
            heightMeters = height / 100;

            double bmi;
            bmi = weight / (heightMeters * heightMeters);
            bmi = Math.Round(bmi, 2);

            Console.WriteLine("{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm", name, surename, age, weight, height);
            Console.WriteLine("BMI is {0}", bmi);
        }
    }
}
