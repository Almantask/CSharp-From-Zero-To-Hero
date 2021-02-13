using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter.Builder.Problems
{
    public class House
    {
        // House is a complex object
        // It always has a wall, roof.
        // It may have a garage, swimming pool...
        public string Walls { get; }
        public string Roof { get; }

        // A house can have either 0 or many garages or swimming pools
        public string Garages { get; internal set; }
        public string SwimmingPools { get; internal set; }

        public House(string walls, string roof)
        {
            Walls = walls;
            Roof = roof;
        }

        public override string ToString() => $"{Walls} {Roof} {Garages} {SwimmingPools}";
    }
}
