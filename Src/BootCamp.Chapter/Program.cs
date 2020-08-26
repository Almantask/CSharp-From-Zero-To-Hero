using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string Surname;
            string AgeEntered;
            int Age;
            string WeightEntered;
            double Weight;
            string HeightEntered;
            double Height;
            double BMICalculated;
            double BMIRounded;
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your surname(last name)?");
            Surname = Console.ReadLine();
            Console.WriteLine("Enter your age as a number please.");
            AgeEntered = Console.ReadLine();
            Age = int.Parse(AgeEntered);
            Console.WriteLine("What is your weight in kilograms?");
            WeightEntered = Console.ReadLine();
            Weight = double.Parse(WeightEntered);
            Console.WriteLine("What is your height in centimeters?");
            HeightEntered = Console.ReadLine();
            Height = double.Parse(HeightEntered);
            BMICalculated = (Weight/Height/Height)*10000;
            BMIRounded = Math.Round(BMICalculated, 1);
            Console.WriteLine(FirstName + " " + Surname + " is " + Age + " years old, their weight is " + Weight + " kg and their height is " + Height + " cm. " + FirstName + " " + Surname + "'s BMI is " + BMIRounded + "%.");
        }
    }
}
