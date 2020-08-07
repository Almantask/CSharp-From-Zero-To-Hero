using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Tell us your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Tell us your surname?");
            var surname = Console.ReadLine();
            Console.WriteLine("Tell us your age?");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Tell us your height(cm)?");
            var height = int.Parse(Console.ReadLine());
            Console.WriteLine("Tell us your weight(KG)?");
            var weight = int.Parse(Console.ReadLine());

            Console.WriteLine(name + "" + surname + " is " + age + " years old , his height is " + height + "cm" + "and his weight is " + weight + "kg" + ".");
            var bmi = (weight / (height * height / 10000));
            Console.WriteLine(name + " " + surname + "body mass index is " + bmi + ".");

            Console.WriteLine("Hello World");
            Console.WriteLine("Tell us your name other person?");
            var Name = Console.ReadLine();
            Console.WriteLine("Tell us your surname?");
            var Surname = Console.ReadLine();
            Console.WriteLine("Tell us your age?");
            var Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Tell us your height(cm)?");
            var Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Tell us your weight(KG)?");
            var Weight = int.Parse(Console.ReadLine());

            Console.WriteLine(Name + "" + Surname + " is " + Age + " years old , his height is " + Height + "cm" + "and his weight is " + Weight + "kg" + ".");
            var BMI = (Weight / (Height * Height / 10000));
            Console.WriteLine(Name + " " + Surname + "body mass index is " + BMI + ".");
        }
    }
}
