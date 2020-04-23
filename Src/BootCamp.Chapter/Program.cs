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
            double weight;
            double heightCM, heightM;

            double BMI;

            for(int i = 0; i < 2; i++)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Surname: ");
                surname = Console.ReadLine();

                Console.Write("Age: ");
                age = Int32.Parse(Console.ReadLine());

                Console.Write("Weight(kg): ");
                weight = Double.Parse(Console.ReadLine());

                Console.Write("Height(cm): ");
                heightCM = Double.Parse(Console.ReadLine());
                heightM = heightCM / 100.0;

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + heightCM + " cm.");

                BMI = weight / (heightM * heightM);
                Console.WriteLine("His Body-Mass Index(BMI) is " + BMI);
            }

        }
    }
}
