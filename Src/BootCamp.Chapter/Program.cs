using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            int weight = 0;
            decimal height = 0;

            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

            age = Convert.ToInt32(Console.ReadLine());
            weight = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToDecimal(Console.ReadLine());


            decimal heightM = height / 100;
            decimal BMI = weight / (heightM * heightM);


            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("His BMI is " + BMI + ".");

            firstName = Console.ReadLine();
            lastName = Console.ReadLine();

            age = Convert.ToInt32(Console.ReadLine());
            weight = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToDecimal(Console.ReadLine());

            heightM = height / 100;
            BMI = weight / (heightM * heightM);


            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("His BMI is " + BMI + ".");
        }
    }
}
