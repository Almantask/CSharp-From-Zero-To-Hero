using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //BMI Calculator//



            Console.Write("BMI Calculator");
            Console.WriteLine();
            Console.Write("start off by entering your age: ");
            string age = Console.ReadLine();


            Console.Write("Now enter your weight in kg: ");
            string weight = Console.ReadLine();

            Console.Write("Lastly enter your height in cm: ");
            string height = Console.ReadLine();

            //converting to doubles//
            double w = Double.Parse(weight);
            double h = Double.Parse(height);



            //calculating bmi// BMI = kg/m 2
            double meter = h * 0.01;
            double square = meter * meter;
            double bmi = w / square;
            Console.WriteLine(bmi);

            //Person 2

            Console.Write("Enter second persons details");
            Console.WriteLine();

            //Person 2 details
            Console.WriteLine("Age");
            string age2 = Console.ReadLine();

            Console.WriteLine("Weight");
            string weight2 = Console.ReadLine();

            Console.WriteLine("Height");
            string height2 = Console.ReadLine();


            //converting to doubles//
            double w2 = Double.Parse(weight2);
            double h2 = Double.Parse(height2);


            //calculating bmi again//
            double meter2 = h2 * 0.01;
            double square2 = meter * meter;
            double bmi2 = w2 / square;
            Console.WriteLine(bmi2);



            Console.ReadLine();
        }
    }
}
