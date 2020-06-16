using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public class MovingSculture
    {
        private readonly Sculture _sculpture;
        private readonly Motor _motor;

        public MovingSculture(Sculture sculpture, Motor motor)
        {
            _sculpture = sculpture;
            _motor = motor;
        }

        public void Move(Vector3 newPosition)
        {
            // interpolate
            _motor.Move(_sculpture, newPosition);
        }
    }
}