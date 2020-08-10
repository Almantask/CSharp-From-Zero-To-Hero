using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string userSurname = Console.ReadLine();
            Console.WriteLine("Age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight (in kg): ");
            int userWeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Height (in cm): ");
            double userHeight = double.Parse(Console.ReadLine());

            double calculateBMI = userWeight / (userHeight * userHeight);

            Console.WriteLine($"{userName} {userSurname} is {userAge} old, his weight is {userWeight} and his height is {userHeight} cm.");
            Console.WriteLine($"{userName}'s BMI is {calculateBMI}");
        }
    }
}
