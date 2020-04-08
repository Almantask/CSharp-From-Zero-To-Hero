using System;
using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Examples.Models;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Method
{
    public static class GroupByDemo
    {
        public static void Run()
        {
            DemoCountByModel();
        }

        private static void DemoCountByModel()
        {
            var cars = SampleSet.Cars2;

            // Get how many cars does each owner have.
            var carsByOwner = cars
                .Where(c => c.OwnerId != null)
                .GroupBy(c => c.OwnerId)
                .ToDictionary(grp => grp.Key)
                .Select(kvp => new {Id = kvp.Key, CarsCount = kvp.Value.Count()});

            // { Id = 2, CarsCount = 1 }
            // { Id = 3, CarsCount = 2 }
            // { Id = 1, CarsCount = 1 }
            carsByOwner.Print();
        }

        private static void DemoOwnersReconstruction()
        {
            var cars = SampleSet.Cars2;
            var people = SampleSet.People1;

            // Get a collection of cars belonging for every person.
            var carOwners = cars
                .GroupBy(c => c.OwnerId)
                .Join(people,
                    c => c.Key,
                    p => p.Id,
                    (cars, person) => new CarOwner(person, cars));

            //Owner: Agnes
            //    Honda CR - V

            //Owner: Gary
            //    Volkswagen Golf
            //    Audi 100
            carOwners.Print();
        }
    }
}
