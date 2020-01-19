using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell me if I did the task wrongly, because I wasn't really sure if I had had to define them and not ask them in.
            //Read name, surename, age, weight (in kg) and height (in cm) from console
            // calculate BMI index
            Console.WriteLine("Type in your firstname");
            string name = Console.ReadLine();
            Console.WriteLine("Type in your lastname");
            string surname = Console.ReadLine();
            Console.WriteLine("Type in your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in your weight(kg)");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in your height(cm)");
            double height = double.Parse(Console.ReadLine());
            double heightM = Math.Pow(height / 100.0,2); //just to convert centimeters into meters, then ^2 them
            double bmi = weight / heightM;
            Console.WriteLine("{0} {1} is {2} years old, his weight is {3} kg and his height {4} cm.",name,surname,age,weight,height);
            Console.WriteLine("His BMI index is: {0}", Math.Round(bmi,2));
            
        }
    }
}
