using System;

namespace BootCamp.Chapter.Examples.SubtleViolation.Bad
{
    public class Square : Rectangle
    {
        // # We have more than we need (only one side is needed)
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
            // Violation #2: if a rectangle was mutable, square is mutable too.
            // So we can change one side, without changing the other, making it a potential rectangle.
            // The below is no longer a square.
            square.Height = 6;
        }
    }
}
