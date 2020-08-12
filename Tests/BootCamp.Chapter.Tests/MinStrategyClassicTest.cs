using System.Collections.Generic;
using BootCamp.Chapter.Examples.MinStrategy;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class MinRawTest
    {
        [Theory]
        [MemberData(nameof(MinExpectation))]
        public void Find_Returns_Minimum(int[] numbers, int expectedMin)
        {
            var strategy = new MinRaw();
            
            var min = strategy.Find(numbers);

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
