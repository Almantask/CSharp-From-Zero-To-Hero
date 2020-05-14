using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class MaxDiffTests
    {
        [Theory]
        [InlineData(555, 888)]
        [InlineData(123456, 820000)]
        [InlineData(10000, 80000)]
        [InlineData(111, 888)]
        public void Solve_Return_MaxDiff(int input, int expectation)
        {
            var actual = MaxDiffSolution.Solve(input);

            actual.Should().Be(expectation);
        }
    }
}
