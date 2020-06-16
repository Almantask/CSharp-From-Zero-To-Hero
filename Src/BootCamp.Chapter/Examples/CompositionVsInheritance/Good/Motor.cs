using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public class Motor
    {
        public void Move(ILocatable locatable, Vector3 position)
        {
            // interpolate
            locatable.Position = position;
        }
    }
}