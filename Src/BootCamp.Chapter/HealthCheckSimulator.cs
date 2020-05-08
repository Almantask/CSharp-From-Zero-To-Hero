using BootCamp.Chapter.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class HealthCheckSimulator
    {
        public static void Run()
        {
            Logger sessionLogger = SetupLogger();

            Person user = new Person(); //We create our test subject
            ConsolePrompter.WelcomeUser();
            SetPersonalDetails(user, sessionLogger);

            Console.WriteLine($"BMI equals: {BMICalculator.CalculateBMI(user, sessionLogger)}");
        }

        private static Logger SetupLogger()
        {
            Console.Write("Please select where would you like to log for this session. 0 = Console, 1 = Logfile: ");
            int logDestination;

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                logDestination = result;
            }
            else
            {
                Console.WriteLine("Invalid value, defaulting to 'Console'.");
                return new Logger(LogTarget.Console);
            }

            switch (logDestination)
            {
                case 0:
                    return new Logger(LogTarget.Console);

                case 1:
                    return new Logger(LogTarget.File);

                default:
                    return new Logger(LogTarget.Console);
            }
        }

        private static void SetPersonalDetails(Person person, Logger logger)
        {
            var firstName = ConsolePrompter.PromptString("Please enter your First Name: ", logger);
            person.FirstName = firstName;

            var lastName = ConsolePrompter.PromptString("Please enter your Last Name: ", logger);
            person.LastName = lastName;

            var age = ConsolePrompter.PromptInt("Please enter your age: ", logger);
            person.Age = age;

            var height = ConsolePrompter.PromptFloat("Please enter your height (in meters, i.e.: 1,8): ", logger);
            person.Height = height;

            var weight = ConsolePrompter.PromptFloat("Please enter your weight (in kg, i.e: 80,5): ", logger);
            person.Weight = weight;
        }


    }
}
