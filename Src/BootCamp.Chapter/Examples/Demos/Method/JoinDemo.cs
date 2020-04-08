using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Method
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
            var carOwners = people // Pair a person...
                .Join(cars, // ...with a car. We need to pair using matching keys.
                    p => p.Id, // Person Id.
                    c => c.OwnerId, // Link to person from a car.
                    (person, car) => new {person.Name, car.Model});

            // { Name = Tom, Model = BMW }
            // { Name = Agnes, Model = Honda }
            // { Name = Gary, Model = Audi }
            carOwners.Print();
        }
    }
}
