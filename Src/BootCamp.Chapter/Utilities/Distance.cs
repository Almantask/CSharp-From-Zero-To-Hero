using System.Drawing;

namespace BootCamp.Chapter.Utilities
{
    public static class Distance
    {
        public static float Calculate(Point p1, Point p2)
        {
            var distance = (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);

            return distance;
        }
    }
}