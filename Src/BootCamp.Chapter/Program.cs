using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of individuals you would like to calculate the BMI of: ");
            int numberOfIndividuals = Convert.ToInt32(Console.ReadLine());

            while (numberOfIndividuals != 0)
            {
                Console.Write("Please enter the individual's first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Please enter the individual's last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Please enter the individual's age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the individual's weight (in kg): ");
                float weight = float.Parse(Console.ReadLine());
                Console.Write("Please enter the individual's height (in cm): ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {weight} kg and their height is {height} cm.");

                float heightInMeters = height / 100f;
                float bodyMassIndex = weight / (MathF.Pow(heightInMeters, 2f)); //BMI equals to kg/m2 hence the number 2
                Console.WriteLine($"{firstName} {lastName}'s BMI is: {bodyMassIndex}");

                numberOfIndividuals--;
            }
        }
    }
}
