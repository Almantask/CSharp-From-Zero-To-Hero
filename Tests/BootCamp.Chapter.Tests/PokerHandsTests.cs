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
        public void AddCards_Given_Empty_Hand_And_A_Card_Returns__Card()
        {
            var cardToBeAdded = new Card(Card.Suites.Clubs, Card.Ranks.Four);
            var hand = new PokerHand();
            var expected = new List<Card>() { new Card(Card.Suites.Clubs, Card.Ranks.Four) };

            hand.AddCards(cardToBeAdded);
            var actual = hand.Reveal();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddCards_Hand_And_Non_Existing_Card_Throws_ArgumentNullException()
        {
            var hand = new PokerHand();

            Action action = () => hand.AddCards(null);

            Assert.Throws<ArgumentNullException>(action);
            
        }

        [Theory]
        [MemberData(nameof(PokerHandExpectations))]
        public void AddCards_Given_Hand_With_6_Cards_Throws_InvalidPokerHandException(Hand hand)
        {
            var card = new Card(Card.Suites.Clubs, Card.Ranks.Nine);

            Action action = () => hand.AddCards(card);

            var ex = Assert.Throws<InvalidPokerHandException>(action);
            Assert.Contains("Invalid hand size.", ex.Message); 
        }

        public static IEnumerable<object[]> PokerHandExpectations
        {
            get
            {
                yield return new object[] { BuildGameWith6Card() };

            }
        }

        private static object BuildGameWith6Card()
        {
            var pokerHand = new PokerHand();
            pokerHand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ace));
            pokerHand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.King));
            pokerHand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Queen));
            pokerHand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Jack));
            pokerHand.AddCards(new Card(Card.Suites.Clubs, Card.Ranks.Ten));
           

            return pokerHand;
        }

       
    }
}
