using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Read name, surename, age, weight (in kg) and height (in cm) from console.

                Print all the info based on the example message below:
                Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.

                Calculate and print body-mass index (BMI)

                Do 1 and 2 for another person.
            */
            GetInfoAndPrint();
            GetInfoAndPrint();
        }

        static void GetInfoAndPrint()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Weight (in kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Height (in cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            double bmi = weight / Math.Pow((height / 100), 2);

            Console.WriteLine($"{name}'s BMI is {bmi}.");
        }
    }
}
