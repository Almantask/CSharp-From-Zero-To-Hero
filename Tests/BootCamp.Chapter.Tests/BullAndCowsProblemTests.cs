using BootCamp.Chapter.Examples.ProblemSolving;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class BullAndCowsProblemTests
    {
        [Theory]
        [InlineData("1", "1", "1A0B")]
        [InlineData("0", "1", "0A0B")]
        [InlineData("1807", "7810", "1A3B")]
        [InlineData("1123", "0111", "1A1B")]
        [InlineData("1122","0001", "0A1B")]
        [InlineData("1122", "2211", "0A4B")]
        public void Solve_Returns_Expected(string secret, string guess, string expectation)
        {
            var cowsBulls = CowsAndBullsProblem.Solve(secret, guess);

            Assert.Equal(expectation, cowsBulls);
        }
    }
}
