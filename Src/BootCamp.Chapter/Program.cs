using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("What is your first name?");
                var name = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                var surname = Console.ReadLine();

                Console.WriteLine("What is your age?");
                var age = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your weight (in lbs)?"); //Murica
                var weight = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your height (in inches)?"); //Murica
                var height = Single.Parse(Console.ReadLine());

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight +
                    " lbs and his height is " + height + " in.");

                const int dumbAmericanBMIConstant = 703;
                float BMI = (weight / (height * height)) * dumbAmericanBMIConstant;
                Console.WriteLine(name + " " + surname + " has a body-mass index(BMI) of " + BMI + " lbs/in^2\n");
            }

        }
    }
}
