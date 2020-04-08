using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Query
{
    public static class SelectManyDemo
    {
        public static void Run()
        {
            Flatten();
            FlattenAndTransform();
        }

        private static void Flatten()
        {
            var carOwners = SampleSet.Carowners;

            // Flattens the lis of cars in car owners.
            var cars = from owner in carOwners
                from car in owner.Cars
                select car;
        }

        private static void FlattenAndTransform()
        {
            var carOwners = SampleSet.Carowners;

            // Flattens the lis of cars in car owners.
            var cars = from owner in carOwners
                from car in owner.Cars
                select new {Owner = owner.Owner.Name, Car = $"{car.Model} {car.Name}"};

            // { Owner = Gareth, Car = Citroen Berlingo }
            // { Owner = Gareth, Car = Volkswagen Golf }
            // { Owner = Nicola, Car = Honda CR - V }
            cars.Print();
        }
    }
}
