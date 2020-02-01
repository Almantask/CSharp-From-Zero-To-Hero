using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your First Name and press ENTER.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please input your Last Name and press ENTER.");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please input your age and press ENTER");
            string age = Console.ReadLine();
            Console.WriteLine("Please input your weight (in kg) and press ENTER");
            var weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input your height (in cm) and press ENTER");
            var height = double.Parse(Console.ReadLine());

            double heightInMeters = height / 100;

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

            var BMI = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("Your BMI is " + Math.Round(BMI, 2) + ".");
        }
    }
}
