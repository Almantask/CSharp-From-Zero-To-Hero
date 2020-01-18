using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            var firstName = Console.ReadLine();
            Console.Write("Surname: ");
            var surName = Console.ReadLine();
            Console.Write("Age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Weight in kilograms: ");
            var weightInKilograms = float.Parse(Console.ReadLine());
            Console.Write("Height in centimeters: ");
            var heightInCentimeters = float.Parse(Console.ReadLine());

            Console.WriteLine($"{firstName} {surName} is {age} years old, his weight is {weightInKilograms} kg and his height is {heightInCentimeters} cm.");
            
            var bodyMassIndex = weightInKilograms / (Math.Pow(heightInCentimeters, 2));
            Console.WriteLine($"Their body mass index is {bodyMassIndex}");
        }
    }
}