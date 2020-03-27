namespace BootCamp.Chapter.Tests
{
    public class ToggleableGrid2dTests : ToggleableGridTests<ToggleableGrid2D>
    {
        protected override ToggleableGrid2D Grid1x1 => new ToggleableGrid2D(new bool[1,1]);
        protected override ToggleableGrid2D Grid1x1Filled => new ToggleableGrid2D(new [,] {{true}});
        protected override ToggleableGrid2D Grid2x2 => new ToggleableGrid2D(new bool[2,2]);
    }
}