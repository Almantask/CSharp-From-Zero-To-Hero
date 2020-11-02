using System;
using System.IO;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person like = new Person("like", 27, 81, 181.5);
            Console.WriteLine($"{like.Name} is {like.Age} years old, his weight is {like.Weight} kg, his height is {like.Height} cm.");
            Console.WriteLine(like.doBMI());
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