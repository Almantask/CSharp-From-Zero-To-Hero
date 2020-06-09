using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Gambling;
using Xunit;

namespace BootCamp.Chapter.Tests.GameComponents
{
    public class CardsTests
    {
        [Theory]
        [MemberData(nameof(GetCardAndName))]
        public void ToString_Returns_Expected_String(Card card, string expectedName)
        {
            var Name = card.ToString();

            Assert.Equal(expectedName, Name);
        }

        public static IEnumerable<object[]> GetCardAndName()
        {
            yield return new object[]{ new Card(Card.Suites.Spades, Card.Ranks.Ace), "Ace of Spades" };
            yield return new object[]{ new Card(Card.Suites.Clubs, Card.Ranks.King), "King of Clubs" };
            yield return new object[]{ new Card(Card.Suites.Diamonds, Card.Ranks.Five), "Five of Diamonds" };
            yield return new object[]{ new Card(Card.Suites.Hearts, Card.Ranks.Queen), "Queen of Hearts" };
        }
    }
}
