using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			{//Line that will ask user for their name.
				Console.Write("Input your full name: ");
				string name = Console.ReadLine();
				Console.WriteLine("Hello again, " + name);
				
				//Line that will ask user for their age. 
				Console.Write(name + ", what is your age? ");
				string age = Console.ReadLine();

				//Line that reads users weight and height.
				Console.Write(name + ", what is your weight in kgs? ");
				string weight = Console.ReadLine();
				Console.Write(name+", what is your height in cm? ");
				string height = Console.ReadLine();

				Console.WriteLine(name + " is " + age + " years old, his weight is " + weight +
					" kgs and his height is " + height + " cm.");

				//Formula for user BMI. 
				//var BMI = height / weight / weight;
				//Console.WriteLine(name + " BMI is " + BMI);
			}

		}

	}
}
