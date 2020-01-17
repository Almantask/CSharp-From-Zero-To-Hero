using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


			{
				// test comment recording chnages test 
				// test 2 
				//CONTROL + F5
				//Need to read Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
				string CarinaName = "Carina";

				string CarinaSurename = "Rod";
				int CarinaAge = 24;
				float CarinaWeight = 63.5f;
				float CarinaHeight = 162.56f;
				float doubleHeight = CarinaHeight * CarinaHeight;
				float CarinaBMI = (CarinaWeight / doubleHeight) * 10000;

				var greeting = CarinaName + " " + CarinaSurename + " is " +
					CarinaAge + " years old, her weight is " +
					CarinaWeight + " kgs and her height is " + CarinaHeight + " cm.";

				Console.WriteLine(greeting);
				Console.WriteLine(CarinaBMI + " BMI");

				string Name = "Alex";

				string alexSurename = "Pez";
				int alexAge = 27;
				float alexWeight = 69.5f;
				float alexHeight = 175.56f;
				float doubleAlexHeight = alexHeight * alexHeight;
				float AlexBMI = (alexWeight / doubleAlexHeight) * 10000;
				//need help with the fraction calculation. 
				//I know 10000 does not belong there but it makes it work. 

				var alexGreeting = Name + " " + alexSurename + " is " +
					alexAge + " years old, her weight is " +
					alexWeight + " kgs and her height is " + alexHeight + " cm.";

				Console.WriteLine(alexGreeting);
				Console.WriteLine(AlexBMI + " BMI");
				//TEST FOR CHANGE MARk 




			}

		}

	}
}
