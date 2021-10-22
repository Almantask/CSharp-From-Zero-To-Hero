using System;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class Lesson9Tests
    {
        [Theory]
        [InlineData("2")]
        [InlineData("a")]
        public void BinaryConverter_ToInteger_Given_Not_A_Binary_Throws_NumberNotABinaryException(string binaryNumber)
        {
            Action action = () => BinaryConverter.ToInteger(binaryNumber);

            action.Should().Throw<InvalidBinaryNumberException>();
        }

        [Theory]
        [InlineData(null, 0)]
        [InlineData("", 0)]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("10", 2)]
        [InlineData("01", 1)]
        [InlineData("100", 4)]
        [InlineData("101", 5)]
        public void BinaryConverter_ToIneger_Given_0sAnd1s_Returns_Expected_Integer(string binaryNumber, long expectedNumber)
        {
            var number = BinaryConverter.ToInteger(binaryNumber);

            number.Should().Be(expectedNumber);
        }

        [Theory]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(2, "10")]
        [InlineData(4, "100")]
        [InlineData(5, "101")]
        public void BinaryConverter_ToBinary_Returns_Expected_Binary(long number, string expectedBinary)
        {
            var binary = BinaryConverter.ToBinary(number);

            binary.Should().Be(expectedBinary);
        }

        [Theory]
        [InlineData('W', '↥')]
        [InlineData('w', '↥')]
        [InlineData('A', '↤')]
        [InlineData('a', '↤')]
        [InlineData('S', '↧')]
        [InlineData('s', '↧')]
        [InlineData('D', '↦')]
        [InlineData('d', '↦')]
        [InlineData('c', '↥')]
        [InlineData('C', '↥')]
        public void ArrowMovement_GetIndicator_Given_Either_Of_WASD_Returns_ExpectedA_Arrow(char symbol, char expectedArrow)
        {
            var arrow = ArrowMovement.GetIndicator(symbol);

            arrow.Should().Be(expectedArrow);
        }
    }
}
