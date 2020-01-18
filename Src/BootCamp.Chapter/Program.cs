using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string surname;
            int age;
            float weight;
            float height;
            float bmi;

            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            surname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your weight in kg?");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is height in cm?");
            height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(firstname + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + "cm");
            Console.WriteLine("This makes his BMI " + weight / ((height / 100) * (height / 100)));

            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            surname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your weight in kg?");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is height in cm?");
            height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(firstname + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + "cm");
            Console.WriteLine("This makes his BMI " + weight / ((height / 100) * (height / 100)));

            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();

            Console.WriteLine("What is your surname?");
            surname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your weight in kg?");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is height in cm?");
            height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(firstname + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + "cm");
            bmi = weight / ((height / 100) * (height / 100));
            Console.WriteLine("This makes his BMI " + bmi);
        }
    }
}
