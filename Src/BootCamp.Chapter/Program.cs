using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name 1:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname 1:");
            string surname = Console.ReadLine();
            Console.WriteLine("Age 1:");
            var age = Console.ReadLine();
            Console.WriteLine("Weight 1 in kg:");
            var weight = Console.ReadLine();
            Console.WriteLine("Height 1 in cm:");
            var height = Console.ReadLine();
            Console.WriteLine($"{name} {surname} is {age} old, his weight is {weight} kg and his height is {height} cm.");
            double weightNr = Convert.ToDouble(weight);
            double heightNr = Convert.ToDouble(height) * .01;
            double BMI = weightNr / (heightNr * heightNr);
            Console.WriteLine($"{name}'s BMI: {BMI}");

            Console.WriteLine("Name 2:");
            name = Console.ReadLine();
            Console.WriteLine("Surname 2:");
            surname = Console.ReadLine();
            Console.WriteLine("Age 2:");
            age = Console.ReadLine();
            Console.WriteLine("Weight 2 in kg:");
            weight = Console.ReadLine();
            Console.WriteLine("Height 2 in cm:");
            height = Console.ReadLine();
            Console.WriteLine($"{name} {surname} is {age} old, his weight is {weight} kg and his height is {height} cm.");
            weightNr = Convert.ToDouble(weight);
            heightNr = Convert.ToDouble(height) * .01;
            BMI = weightNr / (heightNr * heightNr);
            Console.WriteLine($"{name}'s BMI: {BMI}");
        }
    }
}
