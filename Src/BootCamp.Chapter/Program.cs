using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // name, surname, age, weight, height input
            Console.Write("Please input first name: ");
            var name = Console.ReadLine();
            Console.Write("Please input last name: ");
            var surname = Console.ReadLine();
            Console.Write("Please input age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please input weight: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Please input height: ");
            float height = float.Parse(Console.ReadLine());

            // result write line
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            //BMI calculator
            var bmi = weight / (height/100 * height/100);
            
           Console.WriteLine(name + "'s BMI is " + bmi);


        }
    }
}
