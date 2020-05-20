using BootCamp.Chapter.Examples.MaxDiff;
using BootCamp.Chapter.Examples.ProblemSolving;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class MaxDiffSolutionTests
    {
        [Theory]
        [InlineData(555, 888)]
        [InlineData(123456, 820000)]
        [InlineData(10000, 80000)]
        [InlineData(111, 888)]
        public void Solve_Return_MaxDiff(int input, int expected)
        {
            var actual = MaxDiffSolution.Solve(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FromInt_When_int123_Returns_array123()
        {
            var number = 123;
            byte[] expected = {1, 2, 3};

            var digits = DigitsConverter.FromInt(number);

            Assert.Equal(expected, digits);
        }

        [Fact]
        public void FromInt_When_array123_Returns_int123()
        {
            byte[] digits = { 1, 2, 3 };
            var expected = 123;     

            var number = DigitsConverter.ToInt(digits);

            Assert.Equal(expected, number);
        }
    }
}
