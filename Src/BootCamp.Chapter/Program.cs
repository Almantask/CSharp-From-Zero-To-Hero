using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = 0;

            while (peopleCount < 2)
            {
                peopleCount++;
                Console.WriteLine("\nEnter the information below : \n");

                string name;
                Console.WriteLine("name :");
                name = Console.ReadLine();

                string surname;
                Console.WriteLine("surname :");
                surname = Console.ReadLine();

                int age;
                Console.WriteLine("age :");
                age = int.Parse(Console.ReadLine());

                int weight;
                Console.WriteLine("weight :");
                weight = int.Parse(Console.ReadLine());

                int height;
                Console.WriteLine("height :");
                height = int.Parse(Console.ReadLine());

                int BMI;
                BMI = weight / (height*height);
                Console.WriteLine(name +" "+ surname +" "+ "is" + " " + +age+ " " + ",his weight is" + " " + +weight+ " " + "and his height is " +height+"cm");
                Console.WriteLine("BMI ="+BMI);
            }

        }
    }
}
