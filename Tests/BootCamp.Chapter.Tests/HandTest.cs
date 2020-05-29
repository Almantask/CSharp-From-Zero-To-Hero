using BootCamp.Chapter.Gambling;
using System.Collections.Generic;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class HandTest : Gambling.Hand
    {

        [Fact]
        public void Reveal_Returns_CardsInHand()
        {
            List<Card> listOfCards = BuildListOfCards();
            Hand hand = new Hand();
            hand.AddCards(listOfCards.ToArray());

            IEnumerable<Card> returnedListOfCards = hand.Reveal();

            Assert.Equal(returnedListOfCards, listOfCards);
        }

        private static List<Card> BuildListOfCards()
        {
            Card card = new Card(Card.Suites.Clubs, Card.Ranks.Ace);
            List<Card> listOfCards = new List<Card>();
            listOfCards.Add(card);
            listOfCards.Add(card);
            listOfCards.Add(card);
            listOfCards.Add(card);
            return listOfCards;
        }
    }
}
