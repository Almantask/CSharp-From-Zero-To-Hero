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
                string name = Console.ReadLine();

                Console.Write("Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Weight(kg): ");
                float weight = float.Parse(Console.ReadLine());

                Console.Write("Height(cm): ");
                float height = float.Parse(Console.ReadLine());

                float bmi = weight / (float)Math.Pow(height / 100, 2);

                Console.WriteLine($"{name} {surname} is {age} years old, his weight" +
                    $"is {weight} kg and his height is {height:N1} cm.");
                Console.WriteLine($"BMI: {bmi}\n");
            }
            Console.ReadKey();
        }
    }
}