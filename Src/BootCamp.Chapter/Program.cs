using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello first person, what's your first name?"); //First person information.
            string firstName = Console.ReadLine();
            Console.WriteLine("What's your surname");
            string secondName = Console.ReadLine();
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your weight? (In kg)");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your height? (In cm)");
            int height = int.Parse(Console.ReadLine());
            string fullName = (firstName + " " + secondName);
            double heightInMeters = height / 100.0;
            double heightInSquareMeters = heightInMeters * heightInMeters;
            double Bmi = weight / heightInSquareMeters;
            Console.WriteLine(fullName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("Your body-mass index (BMI) is: " + Bmi);

            Console.WriteLine("\nHello second person, what's your first name?"); //Second person information.
            string firstName_2 = Console.ReadLine();
            Console.WriteLine("What's your surname");
            string secondName_2 = Console.ReadLine();
            Console.WriteLine("What's your age?");
            int age_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your weight? (In kg)");
            double weight_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your height? (In cm)");
            int height_2 = int.Parse(Console.ReadLine());
            string fullName_2 = (firstName_2 + " " + secondName_2);
            double heightInMeters_2 = height_2 / 100.0;
            double heightInSquareMeters_2 = heightInMeters_2 * heightInMeters_2;
            double Bmi_2 = weight_2 / heightInSquareMeters_2;
            Console.WriteLine(fullName_2 + " is " + age_2 + " years old, his weight is " + weight_2 + " kg and his height is " + height_2 + " cm.");
            Console.WriteLine("Your body-mass index (BMI) is: " + Bmi_2);
        }
    }
}
