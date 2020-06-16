using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Bad
{
    public class DestructableTile : Tile
    {
        public DestructableTile(Vector3 position) : base(position)
        {
        }

        public void Destroy()
        {
            // Destory
        }
    }
}