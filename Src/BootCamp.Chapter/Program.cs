using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

        StartOver:
            InteractionManager.PerformInteractions();

            Console.WriteLine("Whould you like to start again?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "y") goto StartOver;
        }
    }



    public static class InteractionManager
    {
        public static void PerformInteractions()
        {
            var person = new Person
            {
                Name = Prompter("What is your full name?"),
                Age = int.Parse(Prompter("What is your age?")),
                Weight = double.Parse(Prompter("What is your weight in kg?")),
                Height = double.Parse(Prompter("What is your height in cm?"))
            };

            Console.WriteLine($"{person.Name} is {person.Age} years old, his weight is {person.Weight} kg and his height is {person.Height} cm.");

            Console.WriteLine($"{person.Name} has a BMI of {person.BMI}");
        }

        public static string Prompter(string question)
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
        public double BMI { get { return CalculateBmi(); } }

        private double CalculateBmi()
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
