using System;
using BootCamp.Chapter.Calculator;
using BootCamp.Chapter.Logger;

namespace BootCamp.Chapter
{
    public class Demo
    {
        private readonly ILogger _log = LogSystem.SetLogMode();
        private const string Invalid = "Invalid value, try again.";

        public void Run()
        {
            _log.Logger("Program started.", LogLevel.Warn);
        
            _log.Logger("[Welcome to healthy v0.21]", LogLevel.Info);
            _log.Logger("[Lets create your profile]", LogLevel.Info);
            var person = CreatePersonProfile();
            
            var personalInfo = $"{person.Name} {person.Surname} " +
                               $"is {person.Age} year old, his weight is {person.Weight} " +
                               $"kg and his height is {person.Height} cm.";
            _log.Logger(personalInfo, LogLevel.Info);
            
            _log.Logger("Now press any key to calculate your bmi", LogLevel.Log);
            Console.ReadKey();
            CalculateBmi(person);
            
            _log.Logger("Program finished.", LogLevel.Warn);
        }
        
        private Person CreatePersonProfile()
        {
            _log.Logger("What is your first name?", LogLevel.Log);
            var name = Console.ReadLine();
        
            _log.Logger("What is your surname?", LogLevel.Log);
            var surname = Console.ReadLine();

            _log.Logger("How old are you?", LogLevel.Log);
            var age = ParseToInt();

            _log.Logger("What is your weight(Kg)?", LogLevel.Log);
            var weight = ParseToFloat();
        
            _log.Logger("What is your height(Cm)?", LogLevel.Log);
            var height = ParseToFloat();

            _log.Logger("Creating your profile.", LogLevel.Info);
            return new Person(name, surname, age, weight, height);
        }

        private void CalculateBmi(Person person)
        {
            var bmi = Bmi.CalculatePersonBmi(person);
            _log.Logger($"Your IBM: {bmi}", LogLevel.Log);
        }

        private int ParseToInt()
        {
            do
            {
                if (int.TryParse(Console.ReadLine(), out var intValue)) return intValue;
                _log.Logger(Invalid, LogLevel.Error);
            } while (true);
        }
        
        private float ParseToFloat()
        {
            do
            {
                if (float.TryParse(Console.ReadLine(), out var intValue)) return intValue;
                _log.Logger(Invalid, LogLevel.Error);
            } while (true);
        }
    }
}