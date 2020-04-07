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

            AskQuestions();
            AskQuestions();
        }

        static void AskQuestions()
        {
            Console.WriteLine("Homework#1");
            Console.WriteLine("--------------");

            // Name input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty, please try again.");
                Console.Write("Enter your name: ");
                name = Console.ReadLine().Trim();
            }

            // Surname input
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Surname cannot be empty, please try again.");
                Console.Write("Enter your surname: ");
                surname = Console.ReadLine().Trim();
            }

            // Age input
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine().Trim();
            bool ageValid = false;

            while (ageValid == false)
            {
                if (string.IsNullOrEmpty(ageInput))
                {
                    Console.WriteLine("Age cannot be empty, please try again.");
                    Console.Write("Enter your age: ");
                    ageInput = Console.ReadLine().Trim();
                }
                else if (int.TryParse(ageInput, out int result) == false)
                {
                    Console.WriteLine("Age must be an integer value, please try again.");
                    Console.Write("Enter your age: ");
                    ageInput = Console.ReadLine().Trim();
                }
                else
                {
                    ageValid = true;
                }
            }
            int age = Convert.ToInt32(ageInput);

            // Weight input
            Console.Write("Enter your weight (in kg): ");
            string weightInput = Console.ReadLine().Trim();
            bool weightValid = false;

            while (weightValid == false)
            {
                if (string.IsNullOrEmpty(weightInput))
                {
                    Console.WriteLine("Weight cannot be empty, please try again.");
                    Console.Write("Enter your weight (in kg): ");
                    weightInput = Console.ReadLine().Trim();
                }
                else if (float.TryParse(weightInput, out float result) == false)
                {
                    Console.WriteLine("Weight must be an integer or floating point value, please try again.");
                    Console.Write("Enter your weight (in kg): ");
                    weightInput = Console.ReadLine().Trim();
                }
                else
                {
                    weightValid = true;
                }
            }
            float weight = float.Parse(weightInput);

            // Height input
            Console.Write("Enter your height (in cm): ");
            string heightInput = Console.ReadLine().Trim();
            bool heightValid = false;

            while (heightValid == false)
            {
                if (string.IsNullOrEmpty(heightInput))
                {
                    Console.WriteLine("Height cannot be empty, please try again.");
                    Console.Write("Enter your height (in cm): ");
                    heightInput = Console.ReadLine().Trim();
                }
                else if (float.TryParse(heightInput, out float result) == false)
                {
                    Console.WriteLine("Height must be an integer or floating point value, please try again.");
                    Console.Write("Enter your height (in cm): ");
                    heightInput = Console.ReadLine().Trim();
                }
                else
                {
                    heightValid = true;
                }
            }
            float height = float.Parse(heightInput);

            // Print all data inputed data
            Console.WriteLine("{0} is {1} years old, his weight is {2} kg and his height is {3} cm",
                name + " " + surname,
                age,
                weight,
                height
                );

            // Caculate and print BMI
            float bmi = (weight) / ((height / 100) * (height / 100));
            Console.WriteLine("BMI: {0}", string.Format("{0:F1}", bmi));
            Console.WriteLine("");
        }
    }
}
