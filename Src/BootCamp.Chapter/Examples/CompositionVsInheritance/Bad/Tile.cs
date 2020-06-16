using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Bad
{
    // new classes need to start over for similar functionality

    public class Tile
    {
        public Vector3 Position { get; protected set; }
        public bool IsOcuppied { get; set; } = false;

        public Tile(Vector3 position)
        {
            Position = position;
        }
    }

    // Hard to manage combos, deep hierarchy
}
