using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Examples.Models;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Query
{
    public static class GroupJoinDemo
    {
        public static void Run()
        {
            DemoOwnersReconstruction();
        }

        private static void DemoOwnersReconstruction()
        {
            var cars = SampleSet.Cars2;
            var people = SampleSet.People1;

            // Get a collection of cars belonging for every person.
            var carOwners = from person in people
                join car in cars
                    on person.Id equals car.OwnerId into grouping
                select new CarOwner(person, grouping);

            //Owner: Agnes
            //    Honda CR - V

            //Owner: Gary
            //    Volkswagen Golf
            //    Audi 100

            //Owner: Tom
            //    BMW X1
            carOwners.Print();
        }
    }
}
