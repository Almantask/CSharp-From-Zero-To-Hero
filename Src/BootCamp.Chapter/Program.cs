using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            var surName = Console.ReadLine();
            Console.WriteLine("Age: ");
            var age = Console.ReadLine();
            Console.WriteLine("Weight");
            var weight = Console.ReadLine();
            Console.WriteLine("height");
            var height = Console.ReadLine();

            var print = name + " " + surName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.";

            Console.WriteLine(print);
        }
    }
}
