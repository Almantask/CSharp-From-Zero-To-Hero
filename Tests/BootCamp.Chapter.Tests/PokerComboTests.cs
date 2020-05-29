﻿using BootCamp.Chapter.Gambling.Poker;
using System.Collections.Generic;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PokerComboTests
    {
        [Theory]
        [MemberData(nameof(PokerComboSmallerExpectations))]
        public void Smaller__Given_Set1_Is_Smaller_Set2_Returns_Expected(PokerCombo set1, PokerCombo set2, bool expected)
        {
            var actual = set1 < set2;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(PokerComboEqualExpectations))]
        public void Equal__Given_Set1_Is_Smaller_Set2_Returns_Expected(PokerCombo set1, PokerCombo set2, bool expected)
        {
            var actual = set1 == set2;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(PokerComboGreaterExpectations))]
        public void Greater__Given_Set1_Is_Smaller_Set2_Returns_Expected(PokerCombo set1, PokerCombo set2, bool expected)
        {
            var actual = set1 > set2;

            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> PokerComboSmallerExpectations
        {
            get
            {
                yield return new object[] { new PokerCombo(PokerCombo.Sets.Flush, 0), new PokerCombo(PokerCombo.Sets.RoyalFlush, 0), true };
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.RoyalFlush, 12), true };
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.Flush, 12), false };
            }
        }

        public static IEnumerable<object[]> PokerComboEqualExpectations
        {
            get
            {
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), true};
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.RoyalFlush, 2), false };
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.Pair, 1), false };
            }
        }

        public static IEnumerable<object[]> PokerComboGreaterExpectations
        {
            get
            {
                yield return new object[] { new PokerCombo(PokerCombo.Sets.Flush, 0), new PokerCombo(PokerCombo.Sets.RoyalFlush, 0), false };
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.RoyalFlush, 12), false };
                yield return new object[] { new PokerCombo(PokerCombo.Sets.RoyalFlush, 1), new PokerCombo(PokerCombo.Sets.Flush, 12), true };
            }
        }


    }
}