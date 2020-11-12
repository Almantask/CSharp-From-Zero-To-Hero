using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            int weight;
            int height;
            int BMI;
            int compter = 0;

            while (compter < 2)
            {
                compter++;
                Console.WriteLine("\nEnter the information below : \n");
                Console.WriteLine("name :");
                name = Console.ReadLine();
                Console.WriteLine("surname :");
                surname = Console.ReadLine();
                Console.WriteLine("age :");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("weight :");
                weight = int.Parse(Console.ReadLine());
                Console.WriteLine("height :");
                height = int.Parse(Console.ReadLine());
                BMI = weight / (height*height);
                Console.WriteLine(name +" "+ surname +" "+ "is" + " " + +age+ " " + ",his weight is" + " " + +weight+ " " + "and his height is " +height+"cm");
                Console.WriteLine("BMI ="+BMI);
            }

        }
    }
}
