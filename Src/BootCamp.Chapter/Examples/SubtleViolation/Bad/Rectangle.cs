namespace BootCamp.Chapter.Examples.SubtleViolation.Bad
{
    public class Rectangle
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public float Area => Width * Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
    }
}
