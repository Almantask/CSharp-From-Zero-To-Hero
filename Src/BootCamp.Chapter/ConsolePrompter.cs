using BootCamp.Chapter.Logging;
using System;

namespace BootCamp.Chapter
{
    public static class ConsolePrompter
    {
        public static ILogger SetupSession()
        {
            Console.Write("Please select where would you like to log for this session. 0 = Console, 1 = Logfile: ");

            //We set up our logger with via LoggerFactory
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                // UserInput 1 equals to FileLogger
                if (result == 1)
                    return LoggerFactory.CreateFileLogger();

                // All other Inputs default to ConsoleLogger
                else
                    return LoggerFactory.CreateConsoleLogger();
            }
            else
            {
                Console.WriteLine("Invalid value, defaulting to 'Console'.");
                return LoggerFactory.CreateConsoleLogger();
            }
        }

        public static void WelcomeUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to your annual health check routine. We'd like to collect your information to determine your average health and BMI.");
            Console.ResetColor();
        }

        public static string PromptString(string prompt, ILogger logger)
        {
            logger.Log("Gathering user information...");
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int PromptInt(string prompt, ILogger logger)
        {
            logger.Log("Gathering user information...");

            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }

                logger.LogError("Invalid Value. Please enter another number!");
                continue;
            }
        }

        public static float PromptFloat(string prompt, ILogger logger)
        {
            logger.Log("Gathering user information...");

            while (true)
            {
                Console.Write(prompt);

                if (float.TryParse(Console.ReadLine(), out float result))
                {
                    return result;
                }

                logger.LogError("Incorrect format provided. Please try again!");
                continue;
            }
        }
    }
}
