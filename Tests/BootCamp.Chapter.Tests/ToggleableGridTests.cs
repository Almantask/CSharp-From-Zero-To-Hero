using System;
using BootCamp.Chapter.Tests.Utils;
using FluentAssertions;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace BootCamp.Chapter.Tests
{
    public abstract class ToggleableGridTests<TToggleableGrid> : ConsoleTests 
        where TToggleableGrid : IToggleableGrid
    {
        protected abstract TToggleableGrid Grid1x1 { get; }
        protected abstract TToggleableGrid Grid2x2 { get; }
        protected abstract TToggleableGrid Grid1x1Filled { get; }

        [Theory]
        [InlineData(1,0)]
        [InlineData(-1,0)]
        [InlineData(0,-1)]
        [InlineData(1,1)]
        public void Toggle_Out_Of_Bounds_Throws_IndexOutOfRangeException(int x, int y)
        {
            Action action = () => Grid1x1.Toggle(x, y);

            action.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void Toggle_0_0_Given_1x1_Grid_Cleared_Prints_Black_Square()
        {
            Grid1x1.Toggle(0,0);

            ConsoleOutput.Should().Be("■");
        }

        [Fact]
        public void Toggle_0_0_Given_1x1_Grid_Filled_Deletes_Black_Square()
        {
            Grid1x1Filled.Toggle(0, 0);

            ConsoleOutput.Should().Be("");
        }

        [Fact]
        public void Toggle_1_1_Given_2x2_Grid_Empty_Prints_Black_Square()
        {
            Grid2x2.Toggle(1, 1);

            var expectation = "  " + Environment.NewLine +
                              " ■";
            ConsoleOutput.Should().Be(expectation);
        }
    }
}
