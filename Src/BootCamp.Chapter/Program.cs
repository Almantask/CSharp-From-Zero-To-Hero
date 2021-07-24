﻿using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 2; x++)
            {
                Person person = new Person();

                Console.Write("First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Surname: ");
                person.SurName = Console.ReadLine();

                Console.Write("Age: ");
                person.Age = int.Parse(Console.ReadLine());

                Console.Write("Weight (KG): ");
                person.Weight = float.Parse(Console.ReadLine());

                Console.Write("Height (CM): ");
                person.Height = float.Parse(Console.ReadLine());

                Console.WriteLine(person.Introduction);
                Console.WriteLine($"BMI: {person.BMI} \n");
            }
        }
    }
}
