using System.Numerics;

namespace BootCamp.Chapter.Examples.CompositionVsInheritance.Good
{
    public interface ILocatable
    {
        Vector3 Position { get; set; }
    }
}