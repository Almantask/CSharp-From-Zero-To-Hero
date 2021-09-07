using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //inputs
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Height (cm): ");
                float height = float.Parse(Console.ReadLine());
                Console.Write("Weight (kg): ");
                float weight = float.Parse(Console.ReadLine());

                //BMI calculation : weight/(height^2) (height in metres)
                float bmi = weight / (height / 100 * height / 100);

                Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");
                Console.WriteLine(name + "'s BMI: " + bmi);
                
                //second person
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Surname: ");
                surname = Console.ReadLine();
                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Height (cm): ");
                height = float.Parse(Console.ReadLine());
                Console.Write("Weight (kg): ");
                weight = float.Parse(Console.ReadLine());

                bmi = weight / (height / 100 * height / 100);

                Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");
                Console.WriteLine(name + "'s BMI: " + bmi);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }   
        }
    }
}