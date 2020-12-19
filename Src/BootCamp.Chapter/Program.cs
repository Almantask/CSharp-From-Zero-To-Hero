
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 1.Print all the info based on the example message below:
			   Tom Jefferson is 19 years old, 
			   his weight is 50 kg and his height is 156.5 cm.
			 */

			double height = 156.5;
			int weight = 50;
			int age = 19;
			string surName = "Jefferson";
			string name = "Tom";

			Console.WriteLine($"{name} {surName} you are {age} years old, your weight is {weight} Kg and your height is {height} cm");
			Console.Write("\n");

			// 2.Calculate and print body-mass index (BMI) - Tom Jefferson

			double cm = 156.6;
			double kg = 50.0;
			double bmi = 0.0;

			bmi = kg / (cm * cm) * 10000;
			Console.WriteLine("Tom Jefferson's Body Mass index 'BMI' is: {0}", Math.Round(bmi, 2));
			Console.Write("\n");
			
			// 3. Print all the info with input - Another person

			Console.WriteLine("Enter your details: ");

			Console.Write("Name: ");
			name = Console.ReadLine();

			Console.Write("Surname: ");
			surName = Console.ReadLine();

			Console.Write("Age: ");
			age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Weight: ");
			weight = Convert.ToInt32(Console.ReadLine());

			Console.Write("Height: ");
			height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"{name} {surName} you are {age} years old, your weight is {weight} Kg and your height is {height} cm");
			Console.Write("\n");

			// 3. Calculate and print body-mass index (BMI) with input - Another person

			double centimeters = 0.0;
			double kilograms = 0.0;
			double BMI = 0.0;

			Console.Write("Enter your height in centimeters: ");
			centimeters = double.Parse(Console.ReadLine());

			Console.Write("Enter your weight in kilograms: ");
			kilograms = double.Parse(Console.ReadLine());

			BMI = kilograms / (centimeters * centimeters) * 10000;
			Console.WriteLine("Your Body Mass index 'BMI' is: {0}", Math.Round(bmi, 2));
			Console.Write("\n");
		}
	}
}