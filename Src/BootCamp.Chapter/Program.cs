using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {// For Tom
            string name = "Tom Jefferson ";
            int age = 19;
            float height = 156.5f;
            float weight = 50f;
            Console.WriteLine(name + "is " + age + " years old, his weight is " + weight + "kg and his height is " + height + "cm");
            var BMI = (weight / ((height * height)/10000));
            Console.WriteLine("The Body Mass Index (BMI) of Tom is " + BMI);
         // For someone else. Trying out taking input from the user
            Console.WriteLine("Enter your name, age, height(in cm) and weight(in kg)");
            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surName = Console.ReadLine();
            Console.WriteLine("Age:");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Height(in cm)");
            float height1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Weight(in kg)");
            float weight1 = float.Parse(Console.ReadLine());
            var BMI1 = (weight1 / ((height1 * height1) / 10000));
            Console.WriteLine(firstName + surName + " is " + age1 + " years old, his weight is " + weight1 + "kg and his height is " + height1 + "cm \r\nThe BMI of " + firstName + surName + " is " + BMI1);
        }
    }
}
