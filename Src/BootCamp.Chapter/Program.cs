using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            static string retrieveUserInput(string msg)
            {
                Console.Write(msg);
                return Console.ReadLine();
            }

            static double calculateBMI(int age, int weight, double height)
            {
                return weight / Math.Pow(height / 100, 2);
            }

            static void printHealthStatistics(string name, string surname, int age, int weight, double height)
            {
                double bmi = calculateBMI(age, weight, height);
                Console.WriteLine();
                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
                Console.WriteLine($"They have a BMI of {bmi:0.0}.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }

            printHealthStatistics(
                "Thomas",
                "Jefferson",
                19,
                50,
                156.5
            );

            printHealthStatistics(
                name: retrieveUserInput("Enter a first name: "),
                surname: retrieveUserInput("Enter a last name: "),
                age: Int32.Parse(retrieveUserInput("Enter their age: ")),
                weight: Int32.Parse(retrieveUserInput("Enter their weight in kilograms: ")),
                height: Double.Parse(retrieveUserInput("Enter their height in centimeters: "))
            );

            printHealthStatistics(
                name: retrieveUserInput("Enter a first name: "),
                surname: retrieveUserInput("Enter a last name: "),
                age: Int32.Parse(retrieveUserInput("Enter his age: ")),
                weight: Int32.Parse(retrieveUserInput("Enter his weight in kilograms: ")),
                height: Double.Parse(retrieveUserInput("Enter his height in centimeters: "))
            );
        }
    }
}
