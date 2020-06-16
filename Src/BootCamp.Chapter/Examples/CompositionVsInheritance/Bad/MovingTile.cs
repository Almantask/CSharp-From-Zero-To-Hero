using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Bad
{
    public class MovingTile : Tile
    {
        public MovingTile(Vector3 position) : base(position)
        {
        }

        public void Move(Vector3 location)
        {
            // interpolation...
            Position = location;
        }
    }
}