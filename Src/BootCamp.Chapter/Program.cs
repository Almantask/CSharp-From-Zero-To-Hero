using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Logger.SetTarget(LogTarget.Console);
            Logger.Log($"Program start...{DateTime.Now}");

            var people = AddSampleData();
            PrintResults(people);

            Console.ReadLine();
            Logger.Log($"Program exit...{DateTime.Now}");
        }

        private static void PrintResults(List<Person> people)
        {
            foreach (var person in people)
            {
                Logger.Log($"{person.GetFirstName()} {person.GetLastName()} is {person.GetAge()} old,");
                Logger.Log($"measures {person.GetHeigth()}m, weights {person.GetWeight()}Kg");
                Logger.Log($"and has BMI of {Bmi.Calculate(person)}");
            }
        }

        private static List<Person> AddSampleData()
        {
            List<Person> people = new List<Person>
            {
                new Person("Fox", "Mihail", 36, 83, 1.76f),
                new Person("Schwarzenegger", "Arnold ", 73, 120, 1.88f)
            };

            return people;
        }
    }
}