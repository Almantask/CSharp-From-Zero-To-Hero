using System.Threading.Tasks;
using BootCamp.Chapter.Examples.Shapes_Bridge.Animations;

namespace BootCamp.Chapter.Examples.Shapes_Bridge.Shapes
{
    interface IAnimatedShape : IShape, IAnimation
    {
    }
}
