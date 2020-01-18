using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


			{
				//Test for push function 
				// test comment recording chnages test 
				// test 2 
				//CONTROL + F5
				//Need to read Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
				const string CarinaName = "Carina";

				const string CarinaSurename = "Rod";
				const int CarinaAge = 24;
				const double CarinaWeight = 63.5;
				const double CarinaHeight = 162.56;
				//Why does ¨/¨double weight work in the BMI formula
				const double CarinaBMI = (CarinaWeight / CarinaHeight/CarinaHeight) *10000;

				var greeting = CarinaName + " " + CarinaSurename + " is " +
					CarinaAge + " years old, her weight is " +
					CarinaWeight + " kgs and her height is " + CarinaHeight + " cm.";

				Console.WriteLine(greeting);
				Console.WriteLine(CarinaBMI + " BMI");

				const string Name = "Alex";

				const string alexSurename = "Pez";
				const int alexAge = 27;
				const double alexWeight = 69.5f;
				const double alexHeight = 175.56f;
				const double AlexBMI = (alexWeight / alexHeight/alexHeight)*10000 ;
			
				//need help with the fraction calculation. 
				//I know 10000 does not belong there but it makes it work. 

				var alexGreeting = Name + " " + alexSurename + " is " +
					alexAge + " years old, her weight is " +
					alexWeight + " kgs and her height is " + alexHeight + " cm.";

				Console.WriteLine(alexGreeting);
				Console.WriteLine(AlexBMI + " BMI");
				//TEST FOR CHANGE MARK




			}

		}

	}
}
