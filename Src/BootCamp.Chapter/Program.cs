using System;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create output logger
			IOutputLogger outLogger = new ConsoleLogger();

			//Print boot message
			outLogger.WriteBootMessage();

			//Get 2 sets of inputs
			for (int i = 0; i < 2; i++)
			{
				//Get user inputs
				//First name
				outLogger.Write("First Name: ");
				string firstName = Console.ReadLine();

				//Last name
				outLogger.Write("Last Name: ");
				string lastName = Console.ReadLine();

				//Age
				int age = (int)ReadLineFloat("Age: ", outLogger);

				//Weight
				float kgWeight = ReadLineFloat("Weight(kg): ", outLogger);

				//Height
				float cmHeight = ReadLineFloat("Height(cm): ", outLogger);

				//Log all variables in one line
				outLogger.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {kgWeight} kg and their height is {cmHeight} cm.");

				//Log BMI
				float bmi = GetBmi(kgWeight, cmHeight);
				outLogger.WriteLine($"BMI: {bmi}");
			}

			//Print shutdown message
			outLogger.WriteShutdownMessage();
		}

		private static float ReadLineFloat(string prompt, IOutputLogger outLogger)
		{
			bool isNumber = false;
			string input;
			float num = 0;

			while (!isNumber)
			{
				outLogger.Write(prompt);
				input = Console.ReadLine();
				isNumber = Single.TryParse(input, out num);

				//Log error if didn't enter a number
				if (!isNumber)
				{
					outLogger.WriteErrorMessage($"Error: {input} is not a number.");
				}
			}

			return num;
		}

		private static float GetBmi(float kgWeight, float cmHeight)
		{
			decimal mHeight = (decimal)cmHeight / 100;

			return (float)Math.Round((decimal)kgWeight / (mHeight * mHeight), 1);
		}
	}
}
