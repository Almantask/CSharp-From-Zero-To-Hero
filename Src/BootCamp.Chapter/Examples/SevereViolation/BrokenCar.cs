namespace BootCamp.Chapter.Examples.SevereViolation
{
    public class BrokenCar : Car
    {
        // Violation #1: a broken car doesn't have to have all those parts (it's broken, duh).
        public BrokenCar(Engine engine, Wheel[] wheels, Body body, float speed) : base(engine, wheels, body, speed)
        {
        }

        // Violation #2: there is no point for getting the Speed of a car.

        // Violation #3: a broken car can no longer move.
    }
}