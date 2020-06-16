using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Bad
{
    public class DestructableRocketTile : RocketTile
    {
        public DestructableRocketTile(Vector3 position) : base(position)
        {
        }
    }
}