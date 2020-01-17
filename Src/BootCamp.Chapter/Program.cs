using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(lastName);

            Console.Write("Age: ");
            var age = Console.ReadLine();
            Console.WriteLine(age);

            Console.Write("Height (in cm): ");
            float height = Console.ReadLine();
            Console.WriteLine(height);

            Console.Write("Weight (in kg): ");
            float weight = Console.ReadLine();
            Console.WriteLine(weight);

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + "kg, their height is " + height + " cm and their BMI is ");

            // BMI formula: weight (kg) / [height (m)]2
            // Calculation: [weight(kg) / height(cm) / height(cm)] x 10,000
            // cm to m --> divide by 100

            // my code.. this is where I am having trouble
            // var toMeters = height / 100;
            // var metersSquared = toMeters * toMeters;
            // var bmi = weight / metersSquared;
            // Console.WriteLine(bmi);

        }
    }
}
