using System;
using BootCamp.Chapter.Logger;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Print.Log.Warn("Program started.");
            CalculateBmi();
            Print.Log.Warn("Program finished.");
        }

        private static void CalculateBmi()
        {
            do
            {
                // Get info for BMI calculator
                Print.Log.Info("Body-mass index (BMI) calculator");
                Print.Log.Log("What is your first name?");
                var name = Console.ReadLine();
                
                Print.Log.Log("What is your surname?");
                var surName = Console.ReadLine();
                
                age: Print.Log.Log("How old are you?");
                if (!int.TryParse(Console.ReadLine(), out var age))
                {
                    Print.Log.Error(Constants.Invalid);
                    goto age;
                }
                
                weight: Print.Log.Log("What is your weight(Kg)?");
                if (!float.TryParse(Console.ReadLine(), out var weight))
                {
                    Print.Log.Error(Constants.Invalid);
                    goto weight;
                }
                
                height: Print.Log.Log("What is your height(Cm)?");
                if (!float.TryParse(Console.ReadLine(), out var height))
                {
                    Print.Log.Error(Constants.Invalid);
                    goto height;
                }

                // BMI calculation
                var bodyMassIndex = weight / ((height / 100) * (height / 100));

                // Print info and BMI
                Print.Log.Log($"{name} {surName} is {age} year old, his weight is {weight} kg and " +
                              $"his height is {height} cm.");
                Print.Log.Log($"IBM: {bodyMassIndex}");

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

        private static class Print
        {
            private static readonly ILogger Console = new LogConsole();
            private static readonly ILogger File = new LogFile(@"Log.txt");
            public static readonly ILogger Log = (Constants.DebugLevel == "Console") ? Console : File;
        }
    }
}
