using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter.Examples.Shapes_Bridge
{
    public static class Animator
    {
        public static async Task Animate(Action animate, int interval, int duration)
        {
            var left = duration;
            while (left > 0)
            {
                Console.Clear();
                animate();
                await Task.Delay(interval);
                left -= interval;
            }
        }
    }
}
