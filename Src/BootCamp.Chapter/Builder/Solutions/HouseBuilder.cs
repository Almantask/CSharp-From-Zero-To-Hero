using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCamp.Chapter.Builder.Problems;

namespace BootCamp.Chapter.Builder.Solutions
{
    public class HouseBuilder
    {
        private string _walls;
        private string _roof;
        private List<string> _garages;
        private List<string> _swimmingPools;

        public HouseBuilder(string walls, string roof)
        {
            _walls = walls;
            _roof = roof;

            _garages = new List<string>();
            _swimmingPools = new List<string>();
        }

        public HouseBuilder AddGarage(string garage)
        {
            _garages.Add(garage);
            return this;
        }

        public HouseBuilder AddSwimmingPool(string swimmingPool)
        {
            _swimmingPools.Add(swimmingPool);
            return this;
        }

        public House Build()
        {
            // In case we want to reuse the builder.
            Reset();

            return new (_walls, _roof)
            {
                Garages = string.Join(',', _garages),
                SwimmingPools = string.Join(',', _swimmingPools)
            };
        }

        private void Reset()
        {
            _garages.Clear(); 
            _swimmingPools.Clear();
        }
    }

    public class HouseBuilderv1
    {
        private readonly House _house;

        public HouseBuilderv1(House house)
        {
            _house = house;
        }

        public HouseBuilderv1 AddGarage(string garage)
        {
            // TODO: determine if comma is needed...
            _house.Garages += "," + garage;
            return this;
        }

        public HouseBuilderv1 AddSwimmingPool(string swimmingPool)
        {
            // TODO: determine if comma is needed...
            _house.SwimmingPools += "," + swimmingPool;
            return this;
        }

        public House Build() => _house;
    }

    // Director
    public class StandardHouseBuilder
    {
        // Direct
        public House Build()
        {
            var house = new HouseBuilder("Grey walls", "Brown roof")
                .AddGarage("Small garage")
                .AddSwimmingPool("Small swimming pool")
                .Build();

            return house;
        }
    }

}
