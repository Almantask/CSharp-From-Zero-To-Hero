using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                         Homework #1 
             Read name, surename, age, weight (in kg) and height (in cm) from console.
             1) Print all the info based on the example message below:
             Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 

             2) Calculate and print body-mass index (BMI)
             3) Do 1 and 2 for another person.
             */

            Console.Write("Number of persons: ");
            int count = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Weight(in kg): ");
                var weight = double.Parse(Console.ReadLine());
                Console.Write("Height(in cm): ");
                var height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{name} {surname} is {age} old, his weight is {weight} kg and his height is {height} cm.");

                var bmi = (weight / ((height * height) / 10000));
                Console.WriteLine($"{name} {surname}'s BMI is: {bmi}");

                count--;
            } while (count != 0);
        }
    }
}
