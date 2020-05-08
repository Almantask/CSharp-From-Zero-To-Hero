using BootCamp.Chapter.Logging;
using System;

namespace BootCamp.Chapter
{
    public static class ConsolePrompter
    {
        public static void WelcomeUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to your annual health check routine. We'd like to collect your information to determine your average health and BMI.");
            Console.ResetColor();
        }

        public static string PromptString(string prompt, Logger logger)
        {
            logger.Log("Gathering user information...");
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int PromptInt(string prompt, Logger logger)
        {
            logger.Log("Gathering user information...");

            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }

                if (logger.GetLogTarget() == "Console")
                {
                    logger.LogError("Invalid Value. Please enter another number!");
                    continue;
                }

                Console.WriteLine("Invalid Value. Please enter another number!");
            }
        }

        public static float PromptFloat(string prompt, Logger logger)
        {
            logger.Log("Gathering user information...");

            while (true)
            {
                Console.Write(prompt);

                if (float.TryParse(Console.ReadLine(), out float result))
                {
                    return result;
                }

                if (logger.GetLogTarget() == "Console")
                {
                    logger.LogError("Incorrect format provided. Please try again!");
                    continue;
                }

                Console.WriteLine("Incorrect format provided. Please try again!");
            }
        }
    }
}
