using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Surname:");
            string surName = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight(kg):");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height(cm):");
            decimal height = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName} {surName} is {age} years old, his weight is {weight} kg and his height is {height} cm");
            decimal Bmi = CalculateBMI(weight, height);
            Console.WriteLine($"BMI of {firstName} {surName} is {Bmi}");
            Console.WriteLine("Enter the First name:");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Enter the Surname:");
            string surName1 = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight(kg):");
            decimal weight1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height(cm):");
            decimal height1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName1} {surName1} is {age1} years old, his weight is {weight1} kg and his height is {height1} cm");
            decimal Bmi1 = CalculateBMI(weight1, height1);
            Console.WriteLine($"BMI of {firstName1} {surName1} is {Bmi1}");

        }

        static decimal CalculateBMI(decimal weight, decimal height)
        {
            decimal high = (height / 100) * (height / 100);
            decimal bmi = weight / high;
            return bmi;
        }
    }
}
