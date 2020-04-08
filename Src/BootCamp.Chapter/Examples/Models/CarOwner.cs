using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Models
{
    public class CarOwner
    {
        public Person Owner { get; }
        public IEnumerable<Car> Cars { get; }

        public CarOwner(Person owner, IEnumerable<Car> cars)
        {
            Owner = owner;
            Cars = cars;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Owner: {Owner.Name}");
            foreach (var car in Cars)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString();
        }
    }
}