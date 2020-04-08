using System.Linq;
using System.Net.Http.Headers;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Examples.Models;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Query
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
            var carsByOwner = from car in cars
                              group car by car.OwnerId
                              into grouping
                              select new { Id = grouping.Key, CarsCount = grouping.ToList().Count };

            carsByOwner.Print();
        }
    }
}
