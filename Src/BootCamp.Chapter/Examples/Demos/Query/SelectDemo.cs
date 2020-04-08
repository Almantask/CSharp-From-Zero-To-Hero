using System;
using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Query
{
    public static class SelectDemo
    {
        public static void Run()
        {
            DemoPrimitive();
            DemoCombo();
            DemoAnonym();
        }

        private static void DemoPrimitive()
        {
            var cars = SampleSet.Cars1;

            // Gets all car models from cars1:
            // Citroen, Audi, Suzuki, BMW.
            var models = from car in cars
                select car.Model;
        }

        private static void DemoCombo()
        {
            var carOwners = SampleSet.Carowners;

            // Gets all cars of car names owner for the first car owner
            var cars = from car in 
                (from carOwner in carOwners
                    select carOwner.Cars)
                .FirstOrDefault()
                       select car.Name;

            // Berlingo
            // Golf
            cars.Print();
        }

        private static void DemoAnonym()
        {
            var people = SampleSet.People1;

            var birthdays = from person in people
                            select new { person.Name, person.Birthday};

            // Anonymous gives default prop names,
            // same as: new {Name = P.Name, Birthday = P.Birthday};
            foreach (var birthday in birthdays)
            {
                // Also anonymous objects have default implementation
                // to print property name/value pairs instead of a type name.
                // { Name = Gareth, Birthday = 5/3/2001 12:00:00 AM }
                // { Name = Nicola, Birthday = 5 / 9 / 2003 12:00:00 AM }
                // { Name = Julia, Birthday = 12 / 25 / 1958 12:00:00 AM }
                Console.WriteLine(birthday);
            }
        }
    }
}
