using System;
using System.IO;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lee= new Person("Lee", 27, 81, 181.5);
            Person Tom = new Person("Tom Jefferson", 19, 50, 156.5 );
            Console.WriteLine($"{Lee.Name} is {Lee.Age} years old, his weight is {Lee.Weight} kg, his height is {Lee.Height} cm.");
            Console.WriteLine("Lee's BMI is: " + Lee.doBMI());
            Console.WriteLine($"{Tom.Name} is {Tom.Age} years old, his weight is {Tom.Weight} kg, his height is {Tom.Height} cm.");
            Console.WriteLine("Lee's BMI is: " + Tom.doBMI());
        }
    }
    class Person
    {
        public string Name { get; }
        public int Age { get; }
        public double Weight { get; }
        public double Height { get; }
        public Person(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public double doBMI()
        {
            double result = this.Weight / ((this.Height / 100) * (this.Height / 100));
            return result;

        }
    }
}