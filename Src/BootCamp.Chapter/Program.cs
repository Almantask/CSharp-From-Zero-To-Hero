using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop is introduced to ensure that the program runs exactly 3 times.
            for (int i = 0; i <= 2; i++)
            {
                // Asks user for first name and sets firstName to the input entered by the user
                Console.WriteLine("Please enter the first name.");
                string firstName = Console.ReadLine();

                // Asks user for surname and sets surname to the input entered by the user.
                Console.WriteLine("Please enter the surname.");
                string surname = Console.ReadLine();

                // Asks user for age in years and sets age to the input entered by the user.
                Console.WriteLine("Please enter the age in years.");
                int age = int.Parse(Console.ReadLine());

                // Asks user for weight in kg and sets weight to the input entered by the user.
                Console.WriteLine("Please enter the weight in kg.");
                double weight = double.Parse(Console.ReadLine());

                // Asks user for height in cm and sets height to the input entered by the user
                Console.WriteLine("Please enter the height in cm.");
                double height = double.Parse(Console.ReadLine());

                // Respective 5 inputs are used to print out a line in the console, showing firstName, surname, age, weight and height.
                Console.WriteLine(firstName + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

                // BMI is calculated via dividing the weight by the height divided by 100 to convert it to metres, and squaring it.
                double BMI = weight / Math.Pow(height / 100, 2);

                // BMI is then output onto console.
                Console.WriteLine("Their BMI is " + BMI);
            }
        }
    }
}