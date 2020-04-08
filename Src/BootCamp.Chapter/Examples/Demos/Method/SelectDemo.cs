using System;
using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Method
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
            var models = cars.Select(c => c.Model);
        }

        private static void DemoCombo()
        {
            var carOwners = SampleSet.Carowners;

            // Gets all cars of car names owner for the first car owner
            var cars = carOwners
                .Select(co => co.Cars)
                // .Select(c => c.Name); - doesn't work and refer to select many example for the why.
                // To make it easier we just select from the first set of cars.
                .FirstOrDefault()
                .Select(c => c.Name);

            // Berlingo
            // Golf
            cars.Print();
        }

        private static void DemoAnonym()
        {
            var people = SampleSet.People1;
            // Select to anonymous object
            var birthdays = people.Select(p => new {p.Name, p.Birthday});
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
