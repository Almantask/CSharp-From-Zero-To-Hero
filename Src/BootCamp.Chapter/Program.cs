using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger _consoleLogger = new ConsoleLogger();
            ILogger _fileLogger = new FileLogger();

            ILogger[] loggers = new[] {_consoleLogger, _fileLogger};

            DualLog("Program booted", loggers);

            try
            {
                GetUserInput(loggers);
            }
            catch (Exception e)
            {
                DualLog($"Could not get user input. {e.Message}", loggers);
            }

            DualLog("Program shutdown", loggers);
        }

        static void DualLog(string message, ILogger[] loggers)
        {
            foreach (var logger in loggers)
            {
                logger.Log(message);
            }
        }

        static void GetUserInput(ILogger[] loggers)
        {
            DualLog("What is your name? ", loggers);
            string firstName = Console.ReadLine();
            DualLog($"User entered: {firstName}", loggers);

            DualLog("What is your last name? ", loggers);
            string lastName = Console.ReadLine();
            DualLog($"User entered: {lastName}", loggers);

            DualLog("How old are you? ", loggers);
            string ageInput = Console.ReadLine();
            DualLog($"User entered: {ageInput}", loggers);
            int age;
            try
            {
                age = int.Parse(ageInput);
            }
            catch (Exception e)
            {
                DualLog($"Invalid age. {e.Message}", loggers);
                throw e;
            }

            DualLog("What is your weight (kg)? ", loggers);
            string weightInput = Console.ReadLine();
            DualLog($"User entered: {weightInput}", loggers);
            double weight;
            try
            {
                weight = double.Parse(weightInput);
            }
            catch (Exception e)
            {
                DualLog($"Invalid weight. {e.Message}", loggers);
                throw e;
            }

            DualLog("What is your height (cm)? ", loggers);
            string heightInput = Console.ReadLine();
            DualLog($"User entered: {heightInput}", loggers);
            double height;
            try
            {
                height = double.Parse(heightInput);
            }
            catch (Exception e)
            {
                DualLog($"Invalid weight. {e.Message}", loggers);
                throw e;
            }

            double bmi = weight / Math.Pow((height / 100), 2);

            DualLog(
                $"\n{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. BMI is {bmi}.\n", loggers);
        }
    }
}