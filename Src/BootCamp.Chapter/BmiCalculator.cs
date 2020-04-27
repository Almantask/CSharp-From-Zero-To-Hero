using System;
using BootCamp.Chapter.Logger;

namespace BootCamp.Chapter
{
    public static class BmiCalculator
    {
        private static readonly ILogger ConsoleLogger = new ConsoleLogger();
        private static readonly ILogger FileLogger = new FileLogger(@"Log.txt");
        public static readonly ILogger Logger = (Constants.DebugLevel == "Console") ? ConsoleLogger : FileLogger;
        
        public static void CalculateBmi()
        {
            do
            {
                // Get info for BMI calculator
                Logger.Info("Body-mass index (BMI) calculator");
                Logger.Log("What is your first name?");
                var name = Console.ReadLine();
                
                Logger.Log("What is your surname?");
                var surName = Console.ReadLine();
                
                Logger.Log("How old are you?");
                var age = ParseToInt();
                
                Logger.Log("What is your weight(Kg)?");
                var weight = ParseToFloat();
                
                Logger.Log("What is your height(Cm)?");
                var height = ParseToFloat();

                // BMI calculation
                var bodyMassIndex = weight / ((height / 100) * (height / 100));

                // Print info and BMI
                Logger.Log($"{name} {surName} is {age} year old, his weight is {weight} kg and " +
                           $"his height is {height} cm.");
                Logger.Log($"IBM: {bodyMassIndex}");

                // Ask if user want to do the test again
                Console.WriteLine("Would you like to try again?");
                var response = Console.ReadLine();
                
                if (response != null && (response.ToLower() == "yes" || response.ToLower() == "y"))
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            } while (true);
        }

        private static int ParseToInt()
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out var intValue)) return intValue;
                Logger.Error(Constants.Invalid);
            } while (true);
        }
        
        private static float ParseToFloat()
        {
            do
            {
                if (float.TryParse(Console.ReadLine(), out var intValue)) return intValue;
                Logger.Error(Constants.Invalid);
            } while (true);
        }
    }
}