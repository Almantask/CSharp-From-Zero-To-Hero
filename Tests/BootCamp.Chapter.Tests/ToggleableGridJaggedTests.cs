namespace BootCamp.Chapter.Tests
{
    public class ToggleableGridJaggedTests : ToggleableGridTests<ToggleableGridJagged>
    {
        protected override ToggleableGridJagged Grid1x1 => new ToggleableGridJagged(new bool[1][]{new bool[1]});
        protected override ToggleableGridJagged Grid1x1Filled => new ToggleableGridJagged(new bool[1][] { new [] {true}});
        protected override ToggleableGridJagged Grid2x2 => new ToggleableGridJagged(new bool[2][] { new bool[2], new bool[2] });
    }
}