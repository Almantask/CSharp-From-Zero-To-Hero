using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collect all required information
            Console.WriteLine("Welcome to Personal Information, please enter the required information below");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your weight in KG: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in CM: ");
            double height = Convert.ToDouble(Console.ReadLine());

            //Output all relavant information. 
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " KG and his height is " + height + " CM.");

            //Convert CM to M
            var heightInM = height / 100;

            //Calculate BMI, route to two digits
            double bmi = Math.Round( weight / (heightInM * heightInM),2);

            //Output BMI
            Console.WriteLine("Your BMI is " + bmi);


            Console.WriteLine("Branch Test");
        }
    }
}
