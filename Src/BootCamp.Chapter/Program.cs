using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberOfPersons = 2;
			int currentPerson = 0;

			while (currentPerson < numberOfPersons)
			{
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Surename: ");
				string surename = Console.ReadLine();
				Console.Write("Age: ");
				string years = Console.ReadLine();
				Console.Write("Weight: ");
				string weight = Console.ReadLine();
				Console.Write("Height: ");
				string heigth = Console.ReadLine();

				Console.WriteLine($"{name} {surename} is {years} old, his weight is {weight} kg and his height is {heigth} cm");

				double bmi = Math.Round(Convert.ToDouble(weight) / Math.Pow(Convert.ToDouble(heigth) / 100.0, 2), 2, MidpointRounding.AwayFromZero);

				Console.WriteLine($"Your BMI is: {bmi}\n");

				Console.WriteLine("press ENTER to continue...\n");
				Console.ReadLine();
				currentPerson++;
			}
		}
    }
}
