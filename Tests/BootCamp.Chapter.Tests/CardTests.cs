using BootCamp.Chapter.Gambling;
using System.Linq.Expressions;
using Xunit;
using static BootCamp.Chapter.Gambling.Card;

namespace BootCamp.Chapter.Tests
{
    public class CardTests
    {
        [Fact]
        public void Card_When_Equivalent_Cards_Returns_True()
        {
            var card1 = new Card(Suites.Clubs, Ranks.Ace);
            var card2 = new Card(Suites.Clubs, Ranks.Ace);
            var expected = true;

            var actual = card1.Equals(card2); 

            Assert.Equal(expected, actual);
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