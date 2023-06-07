using System;
using System.Threading;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Get 2 sets of inputs
			for (int i = 0; i < 2; i++)
			{
				//Get user inputs
				//First name
				Console.Write("First Name: ");
				string firstName = Console.ReadLine();

				//Last name
				Console.Write("Last Name: ");
				string lastName = Console.ReadLine();

				//Age
				int age = (int)ReadLineNum("Age: ");

				//Weight
				float kgWeight = ReadLineNum("Weight(kg): ");

				//Height
				float cmHeight = ReadLineNum("Height(cm): ");


				//Print all variables on one line
				Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {kgWeight} kg and their height is {cmHeight} cm.");

				//Print BMI
				float bmi = GetBMI(kgWeight, cmHeight);
				Console.WriteLine($"BMI: {bmi}");
			}

			//Wait to exit
			Console.ReadLine();
		}

		private static float ReadLineNum(string prompt)
		{
			bool isNumber = false;
			string input;
			float num = 0;
			

			while (!isNumber)
			{
				Console.Write(prompt);
				input = Console.ReadLine();
				isNumber = Single.TryParse(input, out num);
			}

			return num;
		}

		private static float GetBMI(float kgWeight, float cmHeight)
		{
			decimal mHeight = (decimal)cmHeight / 100;

			return (float)Math.Round((decimal)kgWeight / (mHeight * mHeight), 1);
		}
	}
}
