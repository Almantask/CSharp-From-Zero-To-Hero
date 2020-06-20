using System.Numerics;

namespace BootCamp.Chapter.Examples.SevereViolation
{
    public interface IMovable
    {
        void Move(Vector3 location);
    }

    public interface ICar : IMovable, ILocatable
    {
    }

    public class Car: ICar
    {
        public Vector3 Location { get; set; }
        public float Speed { get; set; }
        public float KmTraveled { get; private set; }

        private readonly Engine _engine;
        private readonly Wheel[] _wheels;
        private readonly Body _body;

        public Car(Engine engine, Wheel[] wheels, Body body, float speed)
        {
            _engine = engine;
            _wheels = wheels;
            _body = body;
            Speed = speed;
        }

        public void Start()
        {
            _engine.Run();
        }

        public void Move(Vector3 location)
        {
            var distance = Vector3.Distance(Location, location);
            KmTraveled += distance;

            // interpolates
            Location = location;
        }
    }

    public class Body
    {
    }

    public class Wheel
    {
    }

    public class Engine
    {
        public void Run()
        {
        }
    }
}
