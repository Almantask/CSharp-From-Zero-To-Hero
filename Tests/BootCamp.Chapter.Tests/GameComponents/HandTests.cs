using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using BootCamp.Chapter.Gambling;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests.GameComponents
{
    public class HandTests
    {
        private Card[] _someCards = new[]
        {
            new Card(Card.Suites.Spades, Card.Ranks.Ace),
            new Card(Card.Suites.Clubs, Card.Ranks.Two),
            new Card(Card.Suites.Hearts, Card.Ranks.Three)
        };

        [Fact]
        public void AddCards_Given_SomeCards_Add_Cards()
        {
            var hand = new Hand();

            var expectedCards = _someCards.ToList();
            hand.AddCards(_someCards);
            var actualCards = hand.Reveal().ToList();

            Assert.Equal(expectedCards, actualCards);
        }

        [Fact]
        public void Reveal_Given_Returns_Empty_List_When_No_Cards_Added()
        {
            var hand = new Hand();
            
            var expected = new List<Card> { };
            var actual = hand.Reveal();

            Assert.Equal(expected, actual);
        }
    }
}
