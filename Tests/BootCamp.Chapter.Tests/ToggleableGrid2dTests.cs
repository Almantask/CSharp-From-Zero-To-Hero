using Moq;

namespace BootCamp.Chapter.Tests
{
    public class ToggleableGrid2dTests : ToggleableGridTests<ToggleableGrid2D>
    {
        protected override ToggleableGrid2D Grid1x1 => new ToggleableGrid2D(new bool[1,1], Mock.Of<IGridClearer>());
        protected override ToggleableGrid2D Grid1x1Filled => new ToggleableGrid2D(new [,] {{true}}, Mock.Of<IGridClearer>());
        protected override ToggleableGrid2D Grid2x2 => new ToggleableGrid2D(new bool[2,2], Mock.Of<IGridClearer>());
    }
}