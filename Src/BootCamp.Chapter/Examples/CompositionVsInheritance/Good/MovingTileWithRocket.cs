using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public class MovingTileWithRocket
    {
        public Vector3 Position => _tile.Position;
        public bool IsOccupied => _tile.IsOcuppied;

        private readonly Tile _tile;
        private readonly Motor _motor;
        private readonly Rocket _rocket;

        public MovingTileWithRocket(Tile tile, Motor motor, Rocket rocket)
        {
            _tile = tile;
            _motor = motor;
            _rocket = rocket;
        }

        public void Move(Vector3 newPosition) => _motor.Move(_tile, newPosition);
        public void Shoot(Vector3 position) => _rocket.Shoot(position);
    }
}