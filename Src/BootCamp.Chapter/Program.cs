using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            string person1Name = Console.ReadLine();

            Console.Write("Last Name: ");
            string person1Surname = Console.ReadLine();

            Console.Write("Age: ");
            int person1Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            float person1Weight = float.Parse(Console.ReadLine());

            Console.Write("Height: ");
            float person1Height = float.Parse(Console.ReadLine());

            Console.WriteLine("\n" + person1Name + " " + person1Surname + " is " + person1Age + " years old, his weight is " + person1Weight + " kg and his height is " + person1Height + " cm.");
            float BMI1 = person1Weight / ((person1Height / 100) * (person1Height / 100));
            Console.WriteLine("BMI for " + person1Name + ": " + BMI1 + "\n");

            Console.Write("First Name: ");
            string person2Name = Console.ReadLine();

            Console.Write("Last Name: ");
            string person2Surname = Console.ReadLine();

            Console.Write("Age: ");
            int person2Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            float person2Weight = float.Parse(Console.ReadLine());

            Console.Write("Height: ");
            float person2Height = float.Parse(Console.ReadLine());

            Console.WriteLine("\n" + person2Name + " " + person2Surname + " is " + person2Age + " years old, his weight is " + person2Weight + " kg and his height is " + person2Height + " cm.");
            float BMI2 = person2Weight / ((person2Height / 100) * (person2Height / 100));
            Console.WriteLine("BMI for " + person2Name + ": " + BMI2);
        }
    }
}
