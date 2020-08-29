namespace BootCamp.Chapter.Examples.Shapes_Bridge.Shapes
{
    public interface IShape
    {
        void Draw();
        string Pattern { get; }
    }
}
