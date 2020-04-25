using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter

{
    class Program
    {
        public static string name;
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                WriteLine(message: "What's your name? ");
                name = Console.ReadLine();
                BMIFormula();
            }
            Console.ReadKey();
        }

        public static void BMIFormula()
        {
            WriteLine(message: "Age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            WriteLine(message: "Height [Centimeters Only]: ");
            var height = Double.Parse(Console.ReadLine());

            WriteLine(message: "Weight [Kilograms Only]: ");
            var weight = Double.Parse(Console.ReadLine());

            var bmiHeight = height / 100;
            var bmi = weight / bmiHeight / bmiHeight;

            WriteLine(message: $"{name} is {age} years old, their weight is {weight} kg and their height is {height} cm. Therefore, making their BMI [Body Mass Index] {bmi}.\n\n");
        }

        public static void WriteLine(string message)
        {
            Console.Write(message);
        }


    }
}
