using System.Threading.Tasks;
using BootCamp.Chapter.Examples.Shapes_Bridge.Animations;
using BootCamp.Chapter.Examples.Shapes_Bridge.Shapes;

namespace BootCamp.Chapter.Examples.Shapes_Bridge
{
    public static class ShapesExample
    {
        public static async Task Run()
        {
            var rectangle = new AnimatedRectangle(new MoveRight());
            
            await Animator.Animate(rectangle.Animate, 100, 5000);
            //var cirlce = new AnimatedCircle();
        }
    }
}
