using System;

namespace BootCamp.Chapter.Examples.Shapes_Bridge.Shapes
{
    public class AnimatedCircle : IAnimatedShape
    {
        public string Pattern { get; }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Animate()
        {
            throw new NotImplementedException();
        }

        public void AttachShape(IShape shape)
        {
            throw new NotImplementedException();
        }
    }
}
