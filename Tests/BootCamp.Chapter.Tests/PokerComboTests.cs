using BootCamp.Chapter.Gambling.Poker;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PokerComboTests
    {
        [Fact]
        public void Smaller__Given_Set1_Is_Smaller_Set2_Returns_True()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.Flush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 12);

            var actual = set1 < set2;

            Assert.True(actual);
        }

        [Fact]
        public void Smaller__Given_Set1_Is_Equal_Set2_But_Set1_Lower_Score_Returns_True()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 12);

            var actual = set1 < set2;

            Assert.True(actual);
        }

        [Fact]
        public void Smaller__Given_Set1_Is_Greater_Set2_Returns_False()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.Flush, 12);

            var actual = set1 < set2;

            Assert.False(actual);
        }

        [Fact]
        public void Equal__Given_Set1_Is_Equal_To__Set2_Returns_True()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);

            var actual = set1 == set2;

            Assert.True(actual);
        }

        [Fact]
        public void Equal__Given_Set1_IsDifferent_Set_To__Set2_Returns_False()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.Pair, 1);

            var actual = set1 == set2;

            Assert.False(actual);
        }

        [Fact]
        public void Equal__Given_Set1_IsDifferent_Score_To__Set2_Returns_False()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 2);

            var actual = set1 == set2;

            Assert.False(actual);
        }

        [Fact]
        public void Greater__Given_Set1_Is_Greater_Set2_Returns_True()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 12);
            var set2 = new PokerCombo(PokerCombo.Sets.Flush, 12);

            var actual = set1 > set2;

            Assert.True(actual);
        }

        [Fact]
        public void Greater__Given_Set1_Is_Equal_Set2_But_Set1_Higher_Score_Returns_True()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 12);
            var set2 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 1);

            var actual = set1 > set2;

            Assert.True(actual);
        }

        [Fact]
        public void Greater__Given_Set1_Is_Smaller_Set2_Returns_False()
        {
            var set1 = new PokerCombo(PokerCombo.Sets.Flush, 1);
            var set2 = new PokerCombo(PokerCombo.Sets.RoyalFlush, 12);

            var actual = set1 > set2;

            Assert.False(actual);
        }
    }
}