namespace BootCamp.Chapter.Examples.SubtleViolation.Good
{
    public class Rectangle
    {
        public float Width { get; }
        public float Height { get; }
        public float Area => Width * Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
