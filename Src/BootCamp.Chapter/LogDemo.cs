using System;

namespace BootCamp.Chapter
{
    internal class LogDemo
    {
        public static void Demo(Ilogger logger)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            logger.Log($"INFO  {DateTime.Now} The programm has started {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < 2; i++)
            {
                float weight, height;
                GetPersonData(logger, out weight, out height);
                CalculateBMI(logger, weight, height);

            }

            Console.ForegroundColor = ConsoleColor.Green;
            logger.Log($"INFO  {DateTime.Now} The programm has stoppped {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void CalculateBMI(Ilogger logger, float weight, float height)
        {
            var bmi = GetBmi(weight, height);

            logger.Log($"His BMI is:  {bmi:N2}");
        }

        private static void GetPersonData(Ilogger logger, out float weight, out float height)
        {
            Console.Write("What is your name: ");
            var input = Console.ReadLine();
            var name = ValidateInputString(logger, input);

            Console.Write("What is your surname: ");
            input = Console.ReadLine();
            var surname = ValidateInputString(logger, input);

            Console.Write("What is your age: ");
            input = Console.ReadLine();
            var age = ValidateInputInt(logger, input);

            Console.Write("What is your weight in kilogrammes: ");
            input = Console.ReadLine();
            weight = ValidateInputDouble(logger, input);
            Console.Write("What is your height in metres: ");
            input = Console.ReadLine();
            height = ValidateInputDouble(logger, input);
            logger.Log($"{name}  {surname}  is {age} years old, his weight is {weight} kg and his height is {height:F2} cm. {Environment.NewLine}");
        }

        private static float GetBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        private static float ValidateInputDouble(Ilogger logger, string input)
        {
            var isValid = float.TryParse(input, out float number);
            if (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                logger.Log($"ERROR: {DateTime.Now} input schould be a number. {Environment.NewLine}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return number;
        }

        private static object ValidateInputString(Ilogger logger, string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                logger.Log($"ERROR: {DateTime.Now} input schould not be empty.{Environment.NewLine}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return input;
        }

        private static int ValidateInputInt(Ilogger logger, string input)
        {
            var isValid = int.TryParse(input, out int age);
            if (!isValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                logger.Log($"ERROR: {DateTime.Now} age schould be a number. {Environment.NewLine}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return age;
        }
    }
}