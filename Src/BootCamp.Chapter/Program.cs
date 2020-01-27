using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        List<Person> _people = new List<Person>();
        static void Main(string[] args)
        {
            var interactionManger = new InteractionManager();

        StartOver:
            interactionManger.PerformInteractions();

            Console.WriteLine("Whould you like to start again?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "y")
                goto StartOver;
        }
    }



    public class InteractionManager
    {
        private Person _person;

        public void PerformInteractions()
        {
            _person = new Person
            {
                Name = Prompter("What is your full name?"),
                Age = int.Parse(Prompter("What is your age?")),
                Weight = double.Parse(Prompter("What is your weight in kg?")),
                Height = double.Parse(Prompter("What is your height in cm?"))
            };

            Console.WriteLine($"{_person.Name} is {_person.Age} years old, his weight is {_person.Weight} kg and his height is {_person.Height} cm.");

            Console.WriteLine($"{_person.Name} has a BMI of {_person.BMI}");
        }

        public string Prompter(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get { return CalculateBMI(); } }

        private double CalculateBMI()
        {
            if (Weight > 0 && Height > 0)
            {
                var heightInMeters = Height / 100;
                return Weight / (heightInMeters * heightInMeters);
            }

            return 0;
        }
    }
}
