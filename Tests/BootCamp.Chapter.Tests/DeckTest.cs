using BootCamp.Chapter.Gambling;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class DeckTest
    {
        [Fact]
        public void Deck_Created_WithoutCards_Throws_ArgumentNullException()
        {
            List<Card> cards = null;

            Action action = () => new Gambling.Deck(cards);

            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Draw_When_DeckHasNoCards_Throws_OutOfCardsException()
        {
            IDeck deck = new Gambling.Deck(new List<Card>());

            Action action = () => deck.DrawFromTop();

            action.Should().Throw<OutOfCardsException>();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(100)]
        public void DrawAt_OutOfIndex_Throws_IndexOutOfRangeException(int index)
        {
            //Arrange
            List<Card> cards = BuildFullDeckOfCards();
            IDeck deck = new Gambling.Deck(cards);

            //Act
            Action action = () => deck.DrawAt(index);

            //Assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void DrawRandom_52Times_Returns_SameCards_DifferentOrder()
        {
            List<Card> cards = BuildFullDeckOfCards();
            IDeck deck = new Gambling.Deck(cards);
            List<Card> newCards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                newCards.Add(deck.DrawRandom());
            }

            newCards.Should().Contain(cards).And.NotEqual(cards);
        }

        [Fact]
        public void DrawAt_When_IndexWithinRange_Returns_ExpectedCard()
        {
            //Arrange
            List<Card> cards = BuildFullDeckOfCards();
            IDeck deck = new Gambling.Deck(cards);

            //Act
            Card pickedCard = deck.DrawAt(1);

            //Assert wich is better and why?
            Assert.Equal(cards[1], pickedCard);
            //pickedCard.Should().Be(cards[index]);
        }

        [Fact]
        public void DrawFromTop_RemovesACard_And_DrawAt0_Throws_OutOfCardsException()
        {
            //Test if DrawFromTop actually removes a card from deck.

            Card lastCard = new Card(Card.Suites.Hearts, Card.Ranks.Ace);
            List<Card> cards = new List<Card>();
            cards.Add(lastCard);
            IDeck deck = new Gambling.Deck(cards);

            deck.DrawFromTop();
            Action action = () => deck.DrawAt(0);

            action.Should().Throw<OutOfCardsException>();
        }

        [Fact]
        public void DrawFromTop_Given_DeckWith1ExtraCard_Returns_ExpectedCard()
        {
            //Arrange
            Card lastCard = new Card(Card.Suites.Hearts, Card.Ranks.Ace);
            List<Card> cards = BuildFullDeckOfCards();
            cards.Add(lastCard);
            IDeck deck = new Gambling.Deck(cards);

            //Act
            Card cardDrawn = deck.DrawFromTop();

            //Assert
            cardDrawn.Should().Be(lastCard);
        }

        [Fact]
        public void Shuffle_Should_Return_Different_Order()
        {
            //Arrange
            List<Card> cards = BuildFullDeckOfCards();
            IDeck deck = new Gambling.Deck(BuildFullDeckOfCards());

            //Act
            deck.Shuffle();
            List<Card> shuffledDeck = new List<Card>();
            for (int i = 0; i < cards.Count; i++)
            {
                shuffledDeck.Add(deck.DrawFromTop());
            }
            shuffledDeck.Reverse();

            //Assert
            shuffledDeck.Should().Contain(cards).And.NotEqual(cards);
        }
        private static List<Card> BuildFullDeckOfCards()
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

    }
}
