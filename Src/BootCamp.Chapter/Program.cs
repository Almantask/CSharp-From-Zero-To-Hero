using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, ageInput, weightInput, heightInput;
            int age;
            double weight, height, bodyMassIndex;

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Surname: ");
            surname = Console.ReadLine();

            Console.Write("Age: ");
            ageInput = Console.ReadLine();

            Console.Write("Weight: ");
            weightInput = Console.ReadLine();

            Console.Write("Height: ");
            heightInput = Console.ReadLine();

            age = int.Parse(ageInput);
            // Convert age string input weight into int

            weight = double.Parse(weightInput);
            // Convert weight string input weight into double

            height = double.Parse(heightInput);
            // Convert height string input into a double

            double heightInMetres = height / 100;
            // Height is measured in cm, but BMI requires height to be in metres

            bodyMassIndex = (weight) / (heightInMetres * heightInMetres);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm");
            Console.WriteLine($"Body Mass Index: {bodyMassIndex}");

            Console.ReadKey();
        }
    }
}
