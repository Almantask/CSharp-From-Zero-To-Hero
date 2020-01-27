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
        static string _name;
        static int _age;
        static double _weight;
        static double _height;
        static double _bmi;

        public static void PerformInteractions()
        {
            _name = Prompter("What is your full name?");
            _age = int.Parse(Prompter("What is your age?"));
            _weight = double.Parse(Prompter("What is your weight in kg?"));
            _height = double.Parse(Prompter("What is your height in cm?"));

            Console.WriteLine($"{_name} is {_age} years old, his weight is {_weight} kg and his height is {_height} cm.");

            _bmi = CalculateBmi();

            Console.WriteLine($"{_name} has a BMI of {_bmi}");
        }

        private static string Prompter(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static double CalculateBmi()
        {
            if (_weight > 0 && _height > 0)
            {
                var heightInMeters = _height / 100;
                return _weight / (heightInMeters * heightInMeters);
            }

            return 0;
        }
    }
}
