using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Examples.Models;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Query
{
    public static class JoinDemo
    {
        public static void Run()
        {
            DemoJoin();
        }

        private static void DemoJoin()
        {
            var cars = SampleSet.Cars2;
            var people = SampleSet.People1;

            // Join people and car so that we can select something from both.
            var carOwners = from person in people
                            join car in cars
                                on person.Id equals car.OwnerId
                            select new { person.Name, car.Model };

            // { Name = Tom, Model = BMW }
            // { Name = Agnes, Model = Honda }
            // { Name = Gary, Model = Audi }
            carOwners.Print();
        }
    }
}
