using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string sureName = "";
            int age = 0;
            float weight = 0f;
            float height = 0f;

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Surename: ");
            sureName = Console.ReadLine();

            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            weight = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine(name + " is " + age + " years old. " + name + " weight is " + weight + "kg. and height is " + height + ".");

            var bmi = weight / (height * height);
            Console.WriteLine(bmi);

        }
    }
    
}
