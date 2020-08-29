using BootCamp.Chapter.Examples.Shapes_Bridge.Shapes;

namespace BootCamp.Chapter.Examples.Shapes_Bridge.Animations
{
    public interface IAnimation
    {
        void Animate();
        void AttachShape(IShape shape);
    }
}
