using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter person " + (i+1) + " first name:");
                string fName = Console.ReadLine();

                Console.WriteLine("Enter " + fName + "'s last name:");
                string lName = Console.ReadLine();

                Console.WriteLine("Enter " + fName + " " + lName + "'s age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter " + fName + " " + lName + "'s weight in kg:");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter " + fName + " " + lName + "'s height in cm:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(fName + " " + lName + "is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

                double BMI = weight / Math.Pow(height / 100.0, 2);

                Console.WriteLine(fName + " " + lName + "'s BMI is " + BMI);

            }
        }
    }
}
