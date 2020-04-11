using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                // Get info for BMI calculator
                Console.WriteLine("Body-mass index (BMI) calculator");
                Console.WriteLine("What is your first name?");
                string name = Console.ReadLine();
                Console.WriteLine("What is your surname?");
                string surName = Console.ReadLine();
                Console.WriteLine("How old are you?");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your weight(Kg)?");
                float weight = float.Parse(Console.ReadLine());
                Console.WriteLine("What is your height(Cm)?");
                float height = float.Parse(Console.ReadLine());

                // BMI calculation
                float bodyMassIndex = weight / ((height / 100) * (height / 100));

                // Print info and BMI
                Console.WriteLine($"{name} {surName} is {age} year old, his weight is {weight} kg and his height is {height} cm.\n" +
                    $"IBM: {bodyMassIndex}");

                // Ask if user want to do the test again
                Console.WriteLine("Would you like to try again?");
                string response = Console.ReadLine();
                if (response.ToLower() == "yes" || response.ToLower() == "y")
                {
                    Console.Clear();
                }
                else
                {
                    again = false;
                }
            } while (again);
        }
    }
}
