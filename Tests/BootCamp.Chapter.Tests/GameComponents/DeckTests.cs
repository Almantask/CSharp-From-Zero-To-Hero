using System;
using System.Collections.Generic;
using BootCamp.Chapter.Gambling;
using Xunit;

namespace BootCamp.Chapter.Tests.GameComponents
{
    public class DeckTests
    {
        private List<Card> _someCards = new List<Card>
        {
            new Card(Card.Suites.Clubs, Card.Ranks.Ace),
            new Card(Card.Suites.Clubs, Card.Ranks.Two),
            new Card(Card.Suites.Clubs, Card.Ranks.Three)
        };

        [Fact]
        public void Deck_Given_Null_Cards_Throws_ArgumentNullException()
        {
            void NullDeck() => CreateDeck(null);

            Assert.Throws<ArgumentNullException>(NullDeck);
        }

        [Fact]
        public void Deck_DrawAt_Returns_Expected_Card()
        {
            var deck = CreateDeckWithSomeCards();
            Card selectedCard = deck.DrawAt(1);
            Card expectedCard = _someCards[1];

            Assert.Equal(expectedCard, selectedCard);
        }

        [Fact]
        public void Deck_DrawFromTop_Should_Return_Last_Card()
        {
            var deck = CreateDeckWithSomeCards();

            Card expecterdCard = _someCards[_someCards.Count - 1];
            Card selectedCardFromTop = deck.DrawFromTop();

            Assert.Equal(expecterdCard, selectedCardFromTop);
        }

        [Fact]
        public void Deck_DrawAt_Index_More_Than_Card_Count_Throws_OutOfCardsException()
        {
            var deck = CreateDeckWithSomeCards();

             void DrawOutOfIndex() => deck.DrawAt(4);

            Assert.Throws<OutOfCardsException>(DrawOutOfIndex);
        }
        private IDeck CreateDeck(IEnumerable<Card> cards) => new Deck(cards);
        private IDeck CreateDeckWithSomeCards() => CreateDeck(_someCards);
    }
}
