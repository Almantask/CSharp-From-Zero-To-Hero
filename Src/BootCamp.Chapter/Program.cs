using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Homework #1 
            //Read name, surename, age, weight(in kg) and height(in cm) from console.
            //1) Print all the info based on the example message below:
            //Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.
            //2) Calculate and print body-mass index(BMI)
            //3) Do 1 and 2 for another person.

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your weight (in kg): ");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("Enter your height (in cm): ");
            float height = float.Parse(Console.ReadLine());

            float bmi = (weight / ((height * height) / 100)) * 100;

            Console.WriteLine("{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm.", firstName, lastName, age, weight, height);
            Console.WriteLine("His BMI is {0}.", bmi);
        }
    }
}
