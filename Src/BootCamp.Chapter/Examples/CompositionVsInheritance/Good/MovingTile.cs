using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public class MovingTile
    {
        public Vector3 Position => _tile.Position;
        public bool IsOccupied => _tile.IsOcuppied;

        private readonly Tile _tile;
        private readonly Motor _motor;

        public MovingTile(Tile tile, Motor motor)
        {
            _tile = tile;
            _motor = motor;
        }

        public void Move(Vector3 newPosition)
        {
            _motor.Move(_tile, newPosition);
        }
    }
}