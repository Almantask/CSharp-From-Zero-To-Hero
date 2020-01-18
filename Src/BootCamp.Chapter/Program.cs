using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name: ");
                string name = Convert.ToString(Console.ReadLine());

                Console.Write("Surname: ");
                string surname = Convert.ToString(Console.ReadLine());

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Weight: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                string greeting = name + " " + surname + " is " + age +
                " years old, their weight is " + weight + " KG and their height is " + height + "cm.";


                Console.WriteLine(greeting);

                double BMI = weight * 10000 / (height * height);

                Console.WriteLine("BMI: " + BMI);
            }
        }
    }
}
