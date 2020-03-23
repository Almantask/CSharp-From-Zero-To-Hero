using System;
using BootCamp.Chapter.LogUtility;

namespace BootCamp.Chapter
{
    enum LogOption
    {
        Console,
        File
    }

    class Program
    {
        private static ILogger _logger;

        public static void Main(string[] args)
        {
            _logger = SetLogOption(LogOption.Console);

            _logger.Log("Program boots.");

            for (int num = 0; num < 2; num++)
            {
                var person = PromptBmi("Calculate BMI for a person.");
                _logger.Log($"{person.Name} {person.Surname} is {person.Age} years old, his weight is {person.Weight} kg and his height is {person.Height} cm.");
                float bmi = (float)(person.Weight / Math.Pow((person.Height / 100), 2)); //BMI is weight (kg) / [height (m)] ^ 2
                _logger.Log($"Body-mass index (BMI) is {bmi}");
            }

            _logger.Log("Program shutdowns.");
        }

        private static ILogger SetLogOption(LogOption logOption)
        {
            const string LogPath = @"..\..\..\Output\Log.txt";

            if (logOption == LogOption.Console)
            {
                return new ConsoleLogger();
            }
            return new FileLogger(LogPath);
        }

        private static Person PromptBmi(string message)
        {
            _logger.Log(message);

            return new Person()
            {
                Name = PromptText("Enter name: "),
                Surname = PromptText("Enter surname: "),
                Age = Convert.ToInt32(PromptText("Enter age: ")),
                Weight = Convert.ToInt32(PromptText("Enter weight: ")),
                Height = Convert.ToSingle(PromptText("Enter height: "))
            };
        }

        private static string PromptText(string message)
        {
            _logger.Log(message);
            return (Console.ReadLine());
        }
    }
}
