using BootCamp.Chapter.Gambling;
using System;
using System.Collections.Generic;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class DeckTest
    {
        // I cannot test the happy path on the constructor because the variable that  holds the contents is private

        [Fact]
        public void New_Given_Null_List_Throws_NullArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => new Deck(null));
        }

        [Fact]
        public void DrawFromTop_Given_Empty_List_Throws_OutOfCardException()
        {
            var deck = new Deck(new List<Card>() { });

            Assert.Throws<ArgumentOutOfRangeException>(() => deck.DrawFromTop());
        }

        [Theory]
        [MemberData(nameof(deckExpectations))]
        public void DrawFromTop_Given_List_Return_Last_Item(Deck deck, Card expected)
        {
            var actual = deck.DrawFromTop();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DrawRandom_Given_List_One_Card_Returns_That_Card()
        {
            var deck = new Deck(new List<Card>() {new Card(Card.Suites.Diamonds, Card.Ranks.Eight)});
            var expected = new Card(Card.Suites.Diamonds, Card.Ranks.Eight);

            var actual = deck.DrawRandom();

            Assert.Equal(expected, actual); 

        }

        [Fact]
        public void DrawRandom_Empty_List_Throws_OutOfCardExpection()
        {
            var deck = new Deck(new List<Card>() {});
           
            Assert.Throws<OutOfCardsException>(() => deck.DrawRandom()); 

        }

        // Shuffle cannot be tested because there is not way I can make a test that always returns the same.

        public static IEnumerable<object[]> deckExpectations
        {
            get
            {
                yield return new object[] { new Deck(new List<Card>() { new Card(Card.Suites.Clubs, Card.Ranks.Ace) }), new Card(Card.Suites.Clubs, Card.Ranks.Ace) };
                yield return new object[] { new Deck(new List<Card>() { new Card(Card.Suites.Clubs, Card.Ranks.Ace), new Card(Card.Suites.Diamonds, Card.Ranks.King) }), new Card(Card.Suites.Diamonds, Card.Ranks.King) };
            }
        }
    }
}