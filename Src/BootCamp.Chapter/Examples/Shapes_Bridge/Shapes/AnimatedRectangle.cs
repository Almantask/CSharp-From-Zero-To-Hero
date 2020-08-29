using System;
using System.Threading.Tasks;
using BootCamp.Chapter.Examples.Shapes_Bridge.Animations;

namespace BootCamp.Chapter.Examples.Shapes_Bridge.Shapes
{
    public class AnimatedRectangle : IAnimatedShape
    {
        public string Pattern { get; } = $"+--+{Environment.NewLine}" +
                                         $"|  |{Environment.NewLine}" +
                                         $"+--+";

        private readonly IAnimation _animation;
        private readonly int _interval;
        private readonly int _duration;

        public AnimatedRectangle(IAnimation animation)
        {
            _animation = animation;
            _animation.AttachShape(this);
        }

        public void Draw() => Console.WriteLine(Pattern);

        public void Animate()
        {
            _animation.Animate();
        }

        public void AttachShape(IShape shape)
        {
            throw new NotImplementedException();
        }
    }
}
