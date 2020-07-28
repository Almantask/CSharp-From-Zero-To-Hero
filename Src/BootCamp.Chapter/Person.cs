using BootCamp.Chapter.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Person
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _height;

        public void SetInformation(ILogger logger)
        {
            SetName(logger);
            SetAge(logger);
            SetWeight(logger);
            SetHeight(logger);
        }

        public void SetName(ILogger logger)
        {
            while (true)
            {
                Console.WriteLine("Please write your name: ");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    logger.LogMessage("Error: Provided name was empty");
                    continue;
                }

                _name = input;
                return;
            }
        }

        public void SetAge(ILogger logger)
        {
            while (true)
            {
                Console.WriteLine("Please write your age: ");
                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out int age);
                if (!isNumber)
                {
                    logger.LogMessage("Error: Provided age (\"" + input + "\") is not a valid number.");
                    continue;
                }
                else if (age <= 0 || age >= 150)
                {
                    logger.LogMessage("Error: Provided age (\"" + input + "\") is not valid.");
                    continue;
                }

                _age = age;
                return;
            }
        }

        public void SetWeight(ILogger logger)
        {
            while (true)
            {
                Console.WriteLine("Please write your weight in kg: ");
                string input = Console.ReadLine();

                bool isNumber = float.TryParse(input, out float weight);
                if (!isNumber)
                {
                    logger.LogMessage("Error: Provided weight (\"" + input + "\") is not a valid number.");
                    continue;
                }
                else if (weight <= 0)
                {
                    logger.LogMessage("Error: Provided weight (\"" + input + "\") is not valid.");
                    continue;
                }

                _weight = weight;
                return;
            }
        }

        public void SetHeight(ILogger logger)
        {
            while (true)
            {
                Console.WriteLine("Please write your height in cm: ");
                string input = Console.ReadLine();

                bool isNumber = float.TryParse(input, out float height);
                if (!isNumber)
                {
                    logger.LogMessage("Error: Provided height (\"" + input + "\") is not a valid number.");
                    continue;
                }
                else if (height <= 0 )
                {
                    logger.LogMessage("Error: Provided height (\"" + input + "\") is not valid.");
                    continue;
                }

                _height = height;
                return;
            }
        }

        public string GetInformation()
        {
            return $"{_name} is {_age} years ols, their weight is {_weight}kg and their height is {_height} cm";
        }

        public string  CalculateBmi()
        {
            float heighInMeters = _height / 100;
            float bmi = _weight / (heighInMeters * heighInMeters);
            return $"their BMI is {bmi}";
        }
           
    }
}
