using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // name, surname, age, weight, height input
            Console.Write("Please input first name: ");
            string name = Console.ReadLine();
            Console.Write("Please input last name: ");
            string surname = Console.ReadLine();
            Console.Write("Please input age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please input weight in kg: ");
            float weightInKg = float.Parse(Console.ReadLine());
            Console.Write("Please input height in cm: ");
            float heightInCm = float.Parse(Console.ReadLine());

            // result write line
            Console.Write(name + " " + surname + " is " + age + " years old," );
            Console.WriteLine(" his weight is " + weightInKg + " kg and his height is " + heightInCm + " cm.");

            // convert cm to m for BMI
            float heightInM = heightInCm/100;

            //BMI (body-mass index) calculator
            float bmi = weightInKg / (heightInM * heightInM);
            
            Console.WriteLine(name + "'s body-mass index (BMI) is " + bmi);


        }
    }
}
