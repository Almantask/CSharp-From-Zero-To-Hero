using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading first person information: first name, second name, age, weight, height.
            Console.WriteLine("Hello first person, what's your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What's your second name?");
            string secondName = Console.ReadLine();
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your weight? (In kg)");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your height? (In cm)");
            int height = int.Parse(Console.ReadLine());

            // Making BMI formula.
            double heightInMeters = height / 100.0;
            double heightInSquareMeters = heightInMeters * heightInMeters;
            double Bmi = weight / heightInSquareMeters;

            // Making output of his first name, second name, age, weight, height and BMI. 
            Console.WriteLine(firstName + " " + secondName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("Your body-mass index (BMI) is: " + Bmi);

            // Reading second person information: first name, second name, age, weight, height. (I add _2 to every variable)
            Console.WriteLine("\nHello first person, what's your first name?");
            string firstName_2 = Console.ReadLine();
            Console.WriteLine("What's your second name?");
            string secondName_2 = Console.ReadLine();
            Console.WriteLine("What's your age?");
            int age_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your weight? (In kg)");
            double weight_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("What's your height? (In cm)");
            int height_2 = int.Parse(Console.ReadLine());

            // Making BMI formula.
            double heightInMeters_2 = height_2 / 100.0;
            double heightInSquareMeters_2 = heightInMeters_2 * heightInMeters_2;
            double Bmi_2 = weight_2 / heightInSquareMeters_2;

            // Making output of his first name, second name, age, weight, height and BMI. 
            Console.WriteLine(firstName_2 + " " + secondName_2 + " is " + age_2 + " years old, his weight is " + weight_2 + " kg and his height is " + height_2 + " cm.");
            Console.WriteLine("Your body-mass index (BMI) is: " + Bmi_2);
        }
    }
}
