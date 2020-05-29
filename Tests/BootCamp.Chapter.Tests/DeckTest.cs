﻿using BootCamp.Chapter.Gambling;
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
        public void Draw_Given_DeckDeckWithNoCards_Throws_OutOfCardsException()
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
            IDeck deck = BuildFullDeckOfCards();

            //Act
            Action action = () => deck.DrawAt(index);

            //Assert
            action.Should().Throw<IndexOutOfRangeException>();
        }

        [Fact]
        public void DrawRandom_52Times_Returns_SameCards_DifferentOrder()
        {
            BuildListOfCardsGiveItToDeckAndCreateEmptyListOfCards(out List<Card>  cards, out IDeck deck, out List<Card> newCards);

            for (int i = 0; i < 52; i++)
            {
                newCards.Add(deck.DrawRandom());
            }

            newCards.Should().Contain(cards).And.NotEqual(cards);
        }

        [Fact]
        public void DrawRandom_Given_DeckWith1Card_returns_ExcpectedCard()
        {

            //Arrange
            BuildDeckWith1Card(out Card lastCard, out IDeck deck);

            //Act
            Card cardDrawn = deck.DrawRandom();

            //Assert
            cardDrawn.Should().Be(lastCard);
        }

        [Fact]
        public void DrawRandom_Given_DeckWithNoCards_Throws_OutOfCardsException()
        {
            IDeck deck = new Gambling.Deck(new List<Card>());

            Action action = () => deck.DrawRandom();

            action.Should().Throw<OutOfCardsException>();
        }

        [Fact]
        public void DrawAt_When_IndexWithinRange_Returns_ExpectedCard()
        {
            //Arrange
            BuildDeckAndGiveItFullListOfCards(out List<Card> cards, out IDeck deck);

            //Act
            Card pickedCard = deck.DrawAt(1);

            //Assert
            Assert.Equal(cards[1], pickedCard);
        }

        [Fact]
        public void DrawAt0_Given_EmptyDeck_Throws_OutOfCardsException()
        {
            IDeck deck = new Deck(new List<Card>());

            Action action = () => deck.DrawAt(0);

            action.Should().Throw<OutOfCardsException>();
        }

        [Fact]
        public void DrawFromTop_Given_DeckWith1Card_Returns_ExpectedCard()
        {
            //Arrange
            BuildDeckWith1Card(out Card lastCard, out IDeck deck);

            //Act
            Card cardDrawn = deck.DrawFromTop();

            //Assert
            cardDrawn.Should().Be(lastCard);
        }

        [Fact]
        public void Shuffle_Returns_DifferentCardOrder()
        {
            //Arrange
            BuildListOfCardsGiveItToDeckAndShuffle(out List<Card> cards, out IDeck deck, out List<Card> shuffledDeck);

            //Act
            deck.Shuffle();
            for (int i = 0; i < cards.Count; i++)
            {
                shuffledDeck.Add(deck.DrawFromTop());
            }

            //Assert
            shuffledDeck.Should().Contain(cards).And.NotEqual(cards);
        }

        private static void BuildListOfCardsGiveItToDeckAndShuffle(out List<Card> cards, out IDeck deck, out List<Card> shuffledDeck)
        {
            cards = BuildFullListOfCards();
            deck = new Gambling.Deck(BuildFullListOfCards());
            shuffledDeck = new List<Card>();
            cards.Reverse();
        }

        private static List<Card> BuildFullListOfCards()
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

        private static IDeck BuildFullDeckOfCards()
        {
            List<Card> cards = BuildFullListOfCards();
            IDeck deck = new Gambling.Deck(cards);
            return deck;
        }

        private static void BuildListOfCardsGiveItToDeckAndCreateEmptyListOfCards(out List<Card> cards, out IDeck deck, out List<Card> newCards)
        {
            cards = BuildFullListOfCards();
            deck = new Gambling.Deck(cards);
            newCards = new List<Card>();
        }

        private static void BuildDeckWith1Card(out Card lastCard, out IDeck deck)
        {
            lastCard = new Card(Card.Suites.Hearts, Card.Ranks.Ace);
            List<Card> cards = new List<Card>();
            cards.Add(lastCard);
            deck = new Gambling.Deck(cards);
        }

        private static void BuildDeckAndGiveItFullListOfCards(out List<Card> cards, out IDeck deck)
        {
            cards = BuildFullListOfCards();
            deck = new Gambling.Deck(cards);
        }
    }
}
