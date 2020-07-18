using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Name: ");
            string name = Console.ReadLine();
            string title = name;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            title = textInfo.ToTitleCase(title); 

            Console.Write("Input Surname: ");
            string surname = Console.ReadLine();
            string surtitle = surname;
            surtitle = textInfo.ToTitleCase(surtitle); 

            Console.Write("Input Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Input Weight (in kg): ");
            var weight = double.Parse(Console.ReadLine());
            Console.Write("Input Height (in cm): ");
            var height = double.Parse(Console.ReadLine());

            var BMI = weight / ((height*0.01)*(height*0.01));
            BMI = (float) BMI;

            Console.WriteLine($"{title} {surtitle} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"Also the BMI is {BMI}.");

        }
    }
}
