using BootCamp.Chapter.Gambling;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class Tests
    {
        /*
            Card DrawFromTop();
            Card DrawRandom();
            Card DrawAt(int index);
            void Shuffle();
         */
        private List<Card> FullDeckOfCards()
        {
            List<Card> cardsDeck = new List<Card>();
            foreach (Card.Suites suite in (Card.Suites[])Enum.GetValues(typeof(Card.Suites)))
            {
                foreach (Card.Ranks rank in (Card.Ranks[])Enum.GetValues(typeof(Card.Ranks)))
                {
                    cardsDeck.Add(new Card(suite, rank));
                }
            }
            return cardsDeck;
        }

        [Fact]
        public void When_No_Cards_Given_To_Deck_Should_Throw_ArgumentNullException()
        {
            List<Card> cards = null;

            Action action = () => new Deck(cards);

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Draw_When_Deck_Has_No_Cards_Should_Throw_OutOfCardsException()
        {
            IDeck deck = new Deck(new List<Card>());

            Action action = () => deck.DrawFromTop();

            action.Should().Throw<OutOfCardsException>();
        }
        [Fact]
        public void DrawFromTop_Should_Give_Last_Card_In_List()
        {
            //Arrange
            Card lastCard = new Card(Card.Suites.Hearts, Card.Ranks.Ace);
            List<Card> cards = FullDeckOfCards();
            cards.Add(lastCard);
            IDeck deck = new Deck(cards);

            //Act
            Card cardDrawn = deck.DrawFromTop();

            //Assert
            cardDrawn.Should().Be(lastCard);
        }
        [Fact]
        public void Shuffle_Should_Return_Different_Order()
        {
            //Arrange
            List<Card> cards = FullDeckOfCards();
            IDeck deck = new Deck(FullDeckOfCards());

            //Act
            deck.Shuffle();
            List<Card> shuffledDeck = new List<Card>();
            for (int i = 0; i < cards.Count; i++)
            {
                shuffledDeck.Add(deck.DrawFromTop());
            }
            shuffledDeck.Reverse();

            //Assert
            Assert.NotEqual(shuffledDeck, cards);
        }
    }
}
