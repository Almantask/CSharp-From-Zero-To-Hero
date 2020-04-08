using System.Linq;
using BootCamp.Chapter.Examples.Data;
using BootCamp.Chapter.Examples.Models;
using BootCamp.Chapter.Extensions;

namespace BootCamp.Chapter.Examples.Demos.Method
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
            var cars = carOwners.SelectMany(co => co.Cars);
        }

        private static void FlattenAndTransform()
        {
            var carOwners = SampleSet.Carowners;

            // Flattens the lis of cars in car owners.
            var cars = carOwners
                .SelectMany(co => co.Cars,
                    (owner, car) => 
                        new {Owner = owner.Owner.Name, Car = $"{car.Model} {car.Name}"});

            // { Owner = Gareth, Car = Citroen Berlingo }
            // { Owner = Gareth, Car = Volkswagen Golf }
            // { Owner = Nicola, Car = Honda CR - V }
            cars.Print();
        }
    }
}
