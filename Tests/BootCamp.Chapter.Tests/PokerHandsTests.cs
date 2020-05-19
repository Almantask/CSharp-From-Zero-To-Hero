using BootCamp.Chapter.Gambling;
using BootCamp.Chapter.Gambling.Poker;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class PokerHandsTests
    {
        [Fact]
        public void AddCards_Given_Empty_List_And_A_List_With_Elements_Returns_A_List_With_Elements()
        {
            var cardToBeAdded = new Card(Card.Suites.Clubs, Card.Ranks.Four);
            var hand = new PokerHand();
            var expected = new List<Card>() { new Card(Card.Suites.Clubs, Card.Ranks.Four) };

            hand.AddCards(cardToBeAdded);
            var actual = hand.Reveal();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddCards_Given_List_And_Card_Null_Throws_ArgumentNullException()
        {
            var hand = new PokerHand();

            Action action = () => hand.AddCards(null);

            Assert.Throws<ArgumentNullException>(action); 

        }

    }
}
