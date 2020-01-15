using System;

namespace BootCamp.Chapter
{
     static void Main(string[] args)
        {

            for (int i = 0; i < 2; i++)
            {
                Console.Write("What is your name: ");
                var name = Console.ReadLine();

                Console.Write("What is your surname: ");
                var surnname = Console.ReadLine();

                Console.Write("What is your age: ");
                var age = int.Parse(Console.ReadLine());

                Console.Write("What is your weight in kilogram: ");
                float weight = float.Parse(Console.ReadLine());

                Console.Write("What is your height in metres: ");
                float height = float.Parse(Console.ReadLine());

                float bmi = GetBmi(weight, height);

                Console.WriteLine($"{name}  {surnname}  is {age} years old, his weight is {weight} kg and his height is {height:F2} cm.");
                Console.WriteLine($"His BMI is:  {bmi:N2}");
                Console.WriteLine("");
                if (i == 0)
                {
                    Console.WriteLine("Now for another person \n ");
                }
            }
        }

        private static float GetBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }
    }
    
}
