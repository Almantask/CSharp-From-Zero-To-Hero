using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public class Tile: ILocatable
    {
        public Vector3 Position { get; set; }
        public bool IsOcuppied { get; set; } = false;

        public Tile(Vector3 position)
        {
            Position = position;
        }
    }
}