using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            var age = Console.ReadLine();
            var weight = Convert.ToInt32(Console.ReadLine());
            var height = Convert.ToInt32(Console.ReadLine());
            var bmi = (weight / ((height / 100.0) * (height / 100.0)));
            Console.WriteLine(name + " " + surname + " is " + age + " years  old, his weight is " + weight + " kg and his height is " + height + " cm.");
            //System.Console.WriteLine("your bmi is " + bmi);
        }
    }
}
