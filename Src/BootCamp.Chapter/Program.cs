using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type  your First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Type your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your Weight");
            float weight = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Type your Height");
            double height = float.Parse(Console.ReadLine());

            Console.WriteLine(firstName +" " + lastName +" is " + age +" years old, his weight is " + weight + " and his height is " + height);

            double bmi = Convert.ToDouble(weight / (height * height)) * 1000;


            Console.WriteLine("Your BMI is: "+ bmi);

        }
    }
}
