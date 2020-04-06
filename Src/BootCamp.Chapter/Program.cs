using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Read name, surename, age, weight (in kg) and height (in cm) from console.
             * 1) Print all the info based on the example message below:
             * 'Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.'
             * 2) Calculate and print body-mass index (BMI)
             * 3) Do 1 and 2 for another person.
            */

            Question();
            Question();

        }

        static void Question()
        {
            Console.WriteLine("Homework#1");
            Console.WriteLine("--------------");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty, please try again.");
                name = Console.ReadLine().Trim();
            }

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Surname cannot be empty, please try again.");
                surname = Console.ReadLine().Trim();
            }

            // Need to implement validation
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Enter your weight (in kg): ");
            string input = Console.ReadLine().Trim();
            bool valid = false;

            while (valid == false)
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("weight cannot be empty, please try again.");
                    input = Console.ReadLine().Trim();
                }
                // This check will be false if user enters in value as a decimal for example 74.50
                else if (int.TryParse(input, out int result) == false)
                {
                    Console.WriteLine("weight must only include numbers");
                    input = Console.ReadLine().Trim();
                }
                else
                {
                    valid = true;
                }
            }
            float weight = float.Parse(input);

            // Need to implement validation
            Console.Write("Enter your height (in cm): ");
            float height = float.Parse(Console.ReadLine().Trim());

            Console.WriteLine("{0} is {1} years old, his weight is {2} kg and his height is {3} cm",
                name + " " + surname,
                age,
                weight,
                height
                );

            float bmi = (weight) / ((height / 100) * (height / 100));
            Console.WriteLine("BMI: {0}", string.Format("{0:F1}", bmi));
        }
    }
}
