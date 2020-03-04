using System;

namespace BootCamp.Chapter
{
    internal class LogDemo
    {
        internal static void Demo(Illogger logger)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            logger.Log($"INFO  {DateTime.Now} The programm has started {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < 2; i++)
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
                var weight = ValidateInputDouble(logger, input);

                Console.Write("What is your height in metres: ");
                input = Console.ReadLine();
                var  height = ValidateInputDouble(logger, input);

                logger.Log($"{name}  {surname}  is {age} years old, his weight is {weight} kg and his height is {height:F2} cm. {Environment.NewLine}");

                var bmi = GetBmi(weight, height);

                logger.Log($"His BMI is:  {bmi:N2}"); 


            }

            Console.ForegroundColor = ConsoleColor.Green;
            logger.Log($"INFO  {DateTime.Now} The programm has stoppped {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static float GetBmi(float weight, float height)
        {
            return weight / (float)Math.Pow(height, 2);
        }

        private static float ValidateInputDouble(Illogger logger, string input)
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

        private static object ValidateInputString(Illogger logger, string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                logger.Log($"ERROR: {DateTime.Now} input schould not be empty.{Environment.NewLine}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return input;
        }

        private static int ValidateInputInt(Illogger logger, string input)
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