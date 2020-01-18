using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 2; num++)
            {
                Console.WriteLine("Calculate BMI for a person.");

                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter surname: ");
                string surname = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter weight: ");
                float weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter height: ");
                float height = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

                //BMI is weight (kg) / [height (m)] ^ 2
                float bmi = (float)(weight / Math.Pow((height / 100), 2));
                Console.WriteLine("Body-mass index (BMI) is " + bmi);
            }

        }
    }
}
