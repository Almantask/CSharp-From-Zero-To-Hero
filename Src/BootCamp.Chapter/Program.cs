using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: "); 
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height: ");
            var height = Console.ReadLine();
            Console.Write("Weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + height + " cm tall and weighs " + weight*2 + " kg.");
        }
    }
}
