using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Please enter the full name for the first person: ");
            string fullNameFirstPerson = Console.ReadLine();
            
            Console.Write($"{fullNameFirstPerson} please enter your age: ");
            int ageFirstPerson = int.Parse(Console.ReadLine());
            
            Console.Write($"{fullNameFirstPerson} please enter your weight: ");
            double weightFirstPerson = double.Parse(Console.ReadLine());

            Console.Write($"{fullNameFirstPerson} please enter your height: ");
            double heightFirstPerson = double.Parse(Console.ReadLine());
           
            Console.Write("Pelase enter the full name for the second person: ");
            string fullNameSecondPerson = Console.ReadLine();

            Console.Write($"{fullNameSecondPerson} please enter your age: ");
            int ageSecondPerson = int.Parse(Console.ReadLine());

            Console.Write($"{fullNameSecondPerson} please enter your weight: ");
            double weightSecondPerson = double.Parse(Console.ReadLine());

            Console.Write($"{fullNameSecondPerson} please enter your height: ");
            double heightSecondPerson = double.Parse(Console.ReadLine());

            double BMICalculatorFirstPerson = weightFirstPerson / (heightFirstPerson * heightFirstPerson);
            double BMICalculatorSecondPerson = weightSecondPerson / (heightSecondPerson * heightSecondPerson);

            Console.WriteLine($"His name is {fullNameFirstPerson}, and he is {ageFirstPerson} years old. His BMI score is: {BMICalculatorFirstPerson}.");
            Console.WriteLine($"His name is {fullNameSecondPerson}, and he is {ageSecondPerson} years old. His BMI score is: {BMICalculatorSecondPerson}.");
        }
    }
}
