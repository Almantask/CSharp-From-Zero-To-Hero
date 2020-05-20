using System.Collections.Generic;
using BootCamp.Chapter.Examples.ProblemSolving;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class ChipsTests
    {
        [Theory]
        [MemberData(nameof(ExpectedChipsOutput))]
        public void MoveAllToCheapestPlace_Given_NNumbers_Returns_ExpectedCost(int[] input, int expectedCost)
        {
            var cost = Chips.MoveAllToCheapestPlace(input);

            Assert.Equal(expectedCost, cost);
        }

        public static IEnumerable<object[]> ExpectedChipsOutput
        {
            get
            {
                yield return new object[] { new[] { 2, 2, 2, 3, 3 }, 2 };
                yield return new object[] { new[] { 1, 2, 3 }, 1 };
            }
        }
    }
}
