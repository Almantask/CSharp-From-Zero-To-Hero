using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                //Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.
                Console.WriteLine("Input the first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Input the surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Input the age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the weight in kilograms: ");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the height in cm: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(firstName + " " + surname + " is " + age.ToString() + " years old, their weight is " + weight.ToString() + " kg and their height is " + height.ToString() + " cm.");
                double bmi = ((double)weight / (double)height / (double)height) * 10000;
                Console.WriteLine(firstName + " " + surname + "'s bmi is " + bmi.ToString());
            }
            Console.ReadLine();

        }
    }
}
