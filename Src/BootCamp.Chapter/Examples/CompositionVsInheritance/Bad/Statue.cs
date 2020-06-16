using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Bad
{
    public class Statue
    {
        public Vector3 Position { get; protected set; }

        public Statue(Vector3 position)
        {
            Position = position;
        }
    }
}