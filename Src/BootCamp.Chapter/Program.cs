using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 1;
            const int maxEntries = 3;

            while (entry < maxEntries)
            {
                Console.Clear();

                RegisterPerson(entry);

                entry++;
            }
        }

        static void RegisterPerson(int entry)
        {
            Console.WriteLine($"Enter the following information for person #{entry}.");

            Console.Write("Firstname:");
            string firstName = Console.ReadLine();

            Console.Write("Lastname:");
            string lastName = Console.ReadLine();

            Console.Write("Age:");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.Write("Weight in kilograms:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height in meters:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n \n{firstName}{lastName} is {age} years old and his weight is {weight} and his height is {height} \n \n");

            Console.WriteLine($"He/she has a BMI of {weight / (height * height)} \n \n \n");


            Console.WriteLine(entry <= 2
                ? "Press any key to register another person"
                : "Press any key to exit the program");
            Console.ReadKey(true);
        }
    }
}