using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            int personsAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Weight in kg: ");
            double personsWeight = double.Parse(Console.ReadLine());

            Console.Write("Enter Height in cm: ");
            double personsHeight = double.Parse(Console.ReadLine());

            Console.WriteLine(firstName + " " + lastName + " is " + personsAge + " years old, their weight is "
                                + personsWeight + " and their height is " + personsHeight + " cm.");
            Console.WriteLine("Their BMI is " + string.Format("{0:0.#}", (personsWeight / (personsHeight / 100))));

            Console.WriteLine();
            Console.WriteLine("Please Enter a second persons information");

            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            personsAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Weight in kg: ");
            personsWeight = double.Parse(Console.ReadLine());

            Console.Write("Enter Height in cm: ");
            personsHeight = double.Parse(Console.ReadLine());

            Console.WriteLine(firstName + " " + lastName + " is " + personsAge + " years old, their weight is "
                                + personsWeight + " and their height is " + personsHeight + " cm.");
            Console.WriteLine("Their BMI is " + string.Format("{0:0.#}", (personsWeight / (personsHeight / 100))));

            Console.WriteLine();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
