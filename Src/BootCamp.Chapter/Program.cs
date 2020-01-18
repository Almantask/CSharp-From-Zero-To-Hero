using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
			String response;

			do
			{
				Console.WriteLine("Input your first name: ");
				string firstName = Console.ReadLine();
				Console.WriteLine("Input your surname: ");
				string lastName = Console.ReadLine();
				Console.WriteLine("Input your age: ");
				int age = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Input your weight (in kg): ");
				float weight = (float)Double.Parse(Console.ReadLine());
				Console.WriteLine("Input your height (in cm): ");
				float height = (float)Double.Parse(Console.ReadLine());

				Console.WriteLine(firstName + lastName + " is " + age + " years old, his weight is "
					+ weight + " kg and his height is " + height + " cm.");

				float bodyMassIndex = weight / ((height / 100) * (height / 100));
				Console.WriteLine("The BMI of " + firstName + lastName + " is " + bodyMassIndex);

				Console.WriteLine("Would you like to try again, for a different person?");
				response = Console.ReadLine();
			} while (response = "Y");
		}
    }
}
