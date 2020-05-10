using BootCamp.Chapter.Logging;
using System;

namespace BootCamp.Chapter
{
    public static class HealthCheckSimulator
    {
        public static void Run()
        {
            var sessionLogger = ConsolePrompter.SetupSession();
            Person user = new Person(); //We create our test subject
            ConsolePrompter.WelcomeUser();
            SetPersonalDetails(user, sessionLogger);

            Console.WriteLine($"BMI equals: {BMICalculator.CalculateBMI(user, sessionLogger)}");
        }

        private static void SetPersonalDetails(Person person, ILogger logger)
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
