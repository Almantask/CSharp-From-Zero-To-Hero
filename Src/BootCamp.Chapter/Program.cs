using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Joe";
            var surname = "Shmoe";
            var age = 22;
            var weight = 54;
            var height = 170f;

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");
            var heightConverted = height / 100; // height in meters
            var bmi = weight / (heightConverted * heightConverted);
            Console.WriteLine("BMI: " + bmi + "\n");

            name = "Derek";
            surname = "Donuts";
            age = 22;
            weight = 100;
            height = 172.72f;

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");
            heightConverted = height / 100; // height in meters
            bmi = weight / (heightConverted * heightConverted);
            Console.WriteLine("BMI: " + bmi + "\n");

            name = "Bob";
            surname = "Johnson";
            age = 23;
            weight = 100;
            height = 182.88f;

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");
            heightConverted = height / 100; // height in meters
            bmi = weight / (heightConverted * heightConverted);
            Console.WriteLine("BMI: " + bmi + "\n");

        }
    }
}
