using System;

namespace BootCamp.Chapter.Examples.SubtleViolation.Good
{
    public class Square : Rectangle
    {
        // Violation #1: We have more than we need (only one side is needed)
        public Square(float side) : base(side, side)
        {
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            var rectangle = new Rectangle(5, 10);
            var square = new Square(5);

            Console.WriteLine($"Rectangle: {rectangle.Height}, {rectangle.Width}, {rectangle.Area}");
            Console.WriteLine($"Square: {rectangle.Height}, {rectangle.Width}, {rectangle.Area}");
        }
    }
}
