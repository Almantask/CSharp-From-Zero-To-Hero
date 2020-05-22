using BootCamp.Chapter.Gambling;
using System.Collections.Generic;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class TestsHand : Gambling.Hand
    {
        //PS cant remove cards from hand? weird....

        [Fact]
        public void Reveal_Returns_Hand_Given()
        {
            List<Card> listOfCards = BuildListOfCards();
            TestsHand hand = new TestsHand();

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
