using System.Collections.Generic;
using BootCamp.Chapter.Examples.FunctionalMinStrategy;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class MinFinderTests
    {
        [Theory]
        [MemberData(nameof(MinExpectation))]
        public void MinRaw_Returns_Minimum(int[] numbers, int expectedMin)
        {
            // Static is THE EASIEST to test.
            var min = MinFinder.FindRaw(numbers);

            Assert.Equal(expectedMin, min);
        }

        public static IEnumerable<object[]> MinExpectation
        {
            get
            {
                object[] number1Returns1 = {new[]{1}, 1};
                yield return number1Returns1;

                object[] firstSamllestReturnsFirst = { new[] { 1, 2 }, 1};
                yield return firstSamllestReturnsFirst;

                object[] secondSmallestReturnsSecond = { new[] { 2, 1 }, 1};
                yield return secondSmallestReturnsSecond;

                object[] smallestIntheMiddleReturnsTheMiddle = { new[] { 2, 1, 2 }, 1};
                yield return smallestIntheMiddleReturnsTheMiddle;
            }
        }
    }
}
