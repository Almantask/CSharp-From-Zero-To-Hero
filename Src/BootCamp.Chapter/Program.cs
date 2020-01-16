using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            double height;
            double weight;
            String cont = "Y";
            while (cont.Equals("Y") || cont.Equals("y"))
            {
                Console.Write("What is your name?");
                name = Console.ReadLine();
                Console.Write("How old are you?");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("How tall are you? In cm ");
                if (!double.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Something is wrong with your height");
                }
                Console.WriteLine("What is your weight? In kg ");
                if (!double.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("Something is wrong with your weight");
                }
                Console.WriteLine(name + " is" + age + " years old, their weight is " + weight + " kg, and their height is " + height + " cm.");
                Console.WriteLine("Their BMI Index is " + (weight / (height * height))); //Math.Pow(height, 2) = (height * height)
                Console.Write("Do you wish to make an another round? Y/N ");
                cont = Console.ReadLine();
            }
        }
    }
}
