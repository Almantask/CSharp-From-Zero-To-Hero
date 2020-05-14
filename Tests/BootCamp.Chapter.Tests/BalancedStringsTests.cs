using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class BalancedStringsTests
    {
        [Fact]
        public void FindCount_Given_NonEmptyNoLR_Returns_0()
        {
            const string input = "a";

            var balancedStringsCount = BalancedStrings.FindCount(input);

            Assert.Equal(0, balancedStringsCount);
        }

        [Theory]
        [InlineData("LR")]
        [InlineData("RL")]
        public void FindCount_Given_2CharsLR_Returns_1(string input)
        {

            var balancedStringsCount = BalancedStrings.FindCount(input);

            Assert.Equal(1, balancedStringsCount);
        }

        [Theory]
        [InlineData("LLR", 1)]
        [InlineData("LLRRLR", 2)]
        [InlineData("LRLR", 2)]
        [InlineData("LLRLLRL", 2)]
        [InlineData("LLRR", 1)]
        [InlineData("RLRRLLRLRL", 4)]
        [InlineData("RLLLLRRRLR", 3)]
        [InlineData("LLLLRRRR", 1)]
        public void FindCount_Given_ManyCharsWithMirroredLR_Returns_ExpectedCount(string input, int expectedCount)
        {
            var balancedStringsCount = BalancedStrings.FindCount(input);

            Assert.Equal(expectedCount, balancedStringsCount);
        }

        [Theory]
        [InlineData("RLRRRLLRLL", 2)]
        public void FindCount_Given_ManyCharsWithLeftoverLR_Returns_ExpectedCount(string input, int expectedCount)
        {
            var balancedStringsCount = BalancedStrings.FindCount(input);

            Assert.Equal(expectedCount, balancedStringsCount);
        }
    }
}
