using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string firstName;
            string lastName;

            int age;
            int weight;
            double height;

            Console.WriteLine("Please write your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please write your surname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please write your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write your weight in kg: ");
            weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write your height in cm: ");
            height = double.Parse(Console.ReadLine());

            double bmi = weight / ((height * height)) * 10000.0;

            string answer1 = (firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine(answer1);

            string answer2 = (firstName + " has a BMI of " + bmi);
            Console.WriteLine(answer2);

            //Second person starts here

            Console.WriteLine("Please write your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please write your surname: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please write your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write your weight in kg: ");
            weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write your height in cm: ");
            height = double.Parse(Console.ReadLine());

            bmi = weight / ((height * height)) * 10000.0;


            answer1 = (firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine(answer1);


            answer2 = (firstName + " has a BMI of " + bmi);
            Console.WriteLine(answer2);


        }
    }
}
