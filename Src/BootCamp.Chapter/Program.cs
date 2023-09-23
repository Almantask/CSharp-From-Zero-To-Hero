using System;

namespace BootCamp.Chapter
{
    class Program
    {
        // Homework1
        static void Main(string[] args)
        {
            // Person One
            Console.WriteLine(PersonDetails("Tom", "Jefferson", 19, 50, 156.65));
            Console.WriteLine($"BMI = {Math.Round(BodyMassIndex(50, 156.65), 1)}");
            // Person Two
            Console.WriteLine($"\n{PersonDetails("Tommy", "Shelby", 47, 70, 173.00)}");
            Console.WriteLine($"BMI = {Math.Round(BodyMassIndex(70, 173.00), 1)}");
        }
        public static string PersonDetails(string firstName, string lastName, int age, int weight, double height)
        {
            var userDetails = string.Empty;

            userDetails = $"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is ";

            return userDetails;
        }
        public static double BodyMassIndex(int weight, double height)
        {
            var bmi = weight / (Math.Pow((height / 100), 2));

            return bmi;
        }
    }
}

