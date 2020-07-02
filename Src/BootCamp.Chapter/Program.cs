using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string quit = "";
            while (quit != "q")
            {
                string name = getUserString("Name");
                double age = getUserDouble("age");
                double weight = getUserDouble("weight(Kg)");
                double height = getUserDouble("height(cm)");

                Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                var BMI = calculateBMI(weight, height);

                Console.WriteLine($"{name}'s BMI is: {BMI}.");

                Console.WriteLine("Enter \"q\" to quit or press any other key to continue ");
                quit = Console.ReadLine();
            }

        }

        public static double calculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100.0;
            return weight / Math.Pow(heightInMeters, 2);
        }

        public static string getUserString(string requestedInfo)
        {
            string response;
            Console.WriteLine($"please input {requestedInfo}: ");
            return response = Console.ReadLine();

        }


        public static double getUserDouble(string requestedInfo)
        {
            string response;
            Console.WriteLine($"please input {requestedInfo}: ");
            response = Console.ReadLine();

            double number;
            Double.TryParse(response, out number);

            return number;

        }
    }
    
}
