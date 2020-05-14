using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class ChipsTests
    {
        [Fact]
        public void MoveAllToCheapestPlace_Given_EmptyArray_Returns_0()
        {
            var input = new int[0];

            var cost = Chips.MoveAllToCheapestPlace(input);

            Assert.Equal(0, cost);
        }

        [Fact]
        public void MoveAllToCheapestPlace_Given_1Number_Returns_0()
        {
            var input = new int[] {1};

            var cost = Chips.MoveAllToCheapestPlace(input);

            Assert.Equal(0, cost);
        }

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
