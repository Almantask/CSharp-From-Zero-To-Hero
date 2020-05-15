using BootCamp.Chapter.Gambling;
using Xunit;
using static BootCamp.Chapter.Gambling.Card;

namespace BootCamp.Chapter.Tests
{
    public class CardTests
    {
        private readonly Card card;
        private readonly Suites expectedSuite = Suites.Diamonds;
        private readonly Ranks expectedRank = Ranks.Eight;

        public CardTests()
        {
            card = new Card(expectedSuite, expectedRank);
        }

        [Fact]
        public void Card_When_Given_Suite_Sets_Suite() => Assert.Equal(expectedSuite, card.Suite);

        [Fact]
        public void Card_When_Given_Suite_Sets_Ranks() => Assert.Equal(expectedRank, card.Rank);

        [Fact]
        public void Card_When_Equivalent_Cards_Returns_True()
        {
            var other = new Card(expectedSuite, expectedRank);

            Assert.Equal(card, other);
        }

        [Fact]
        public void ToString_Given_SuitAndRank_Returns_String()
        {
            var expected = "Two of Hearts";

            var card = new Card(Card.Suites.Hearts, Card.Ranks.Two).ToString();

            Assert.Equal(expected, card);
        }
    }
}