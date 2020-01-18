using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            int weight;
            float height;
            float bmi;

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter weight: ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            //BMI is weight (kg) / [height (m)] ^ 2
            bmi = (float)(weight / Math.Pow((height / 100), 2));
            Console.WriteLine("Body-mass index (BMI) is " + bmi);
        }
    }
}
