using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Bad
{
    public class RocketTile : Tile
    {
        public RocketTile(Vector3 position) : base(position)
        {
        }

        public void Shoot(Vector3 location)
        {

        }
    }
}