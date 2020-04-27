using System;
using BootCamp.Chapter.Calculator;
using BootCamp.Chapter.Logger;

namespace BootCamp.Chapter
{
    public class CalculateBmi
    {
        public void Calculate()
        {
            var log = SetDebugMode();
            log.Logger("Program started.", Log.Level.Warn);
        
            log.Logger("Body-mass index (BMI) calculator", Log.Level.Info);
            log.Logger("What is your first name?", Log.Level.Log);
            var name = Console.ReadLine();
        
            log.Logger("What is your surname?", Log.Level.Log);
            var surname = Console.ReadLine();

            log.Logger("How old are you?", Log.Level.Log);
            var age = ParseToInt();

            log.Logger("What is your weight(Kg)?", Log.Level.Log);
            var weight = ParseToFloat();
        
            log.Logger("What is your height(Cm)?", Log.Level.Log);
            var height = ParseToFloat();
        
            log.Logger("Creating new calculator instance.", Log.Level.Info);
            log.Logger("Calculating BMI.", Log.Level.Info);
            var bmi = new BmiCalculator(name, surname, age, weight, height);

            var personalInfo = $"{bmi.Person.Name} {bmi.Person.Surname} " +
                               $"is {bmi.Person.Age} year old, his weight is {bmi.Weight} " +
                               $"kg and his height is {bmi.Height} cm.";
            log.Logger(personalInfo, Log.Level.Log);
            var bmiValue = $"IBM: {bmi.Bmi}";
            log.Logger(bmiValue, Log.Level.Log);
        
            log.Logger("Program finished.", Log.Level.Warn);
        }
        
        private static ILogger SetDebugMode()
        {
            if (Constants.DebugLevel == "Console")
            {
                return new ConsoleLogger();
            }
            else
            {
                return new FileLogger(@"Log.txt");
            }
        }
        
        private static int ParseToInt()
        {
            var log = SetDebugMode();
            do
            {
                if (int.TryParse(Console.ReadLine(), out var intValue)) return intValue;
                log.Logger(Constants.Invalid, Log.Level.Error);
            } while (true);
        }
        
        private static float ParseToFloat()
        {
            var log = SetDebugMode();
            do
            {
                if (float.TryParse(Console.ReadLine(), out var intValue)) return intValue;
                log.Logger(Constants.Invalid, Log.Level.Error);
            } while (true);
        }
    }
}