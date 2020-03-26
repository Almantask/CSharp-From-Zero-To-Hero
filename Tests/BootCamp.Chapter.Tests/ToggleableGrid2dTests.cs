namespace BootCamp.Chapter.Tests
{
    public class ToggleableGrid2dTests : ToggleableGridTests<ToggleableGrid2d>
    {
        protected override ToggleableGrid2d Grid1x1 => new ToggleableGrid2d(new bool[1][]{new bool[1]});
        protected override ToggleableGrid2d Grid1x1Filled => new ToggleableGrid2d(new bool[1][] { new [] {true}});
        protected override ToggleableGrid2d Grid2x2 => new ToggleableGrid2d(new bool[2][] { new bool[2], new bool[2] });
    }
}