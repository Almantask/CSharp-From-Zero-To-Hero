using BootCamp.Chapter.Gambling;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class CardTests
    {
        [Fact]
        public void New_Given_SuitAndRank_Sets_SuiteAndRank()
        {
            var expected = new Card(Card.Suites.Hearts, Card.Ranks.Two); 

            var card = new Card(Card.Suites.Hearts, Card.Ranks.Two);

            Assert.Equal(expected, card); 
        }

        [Fact]
        public void ToString_Given_FalseSuitAndRank_Returns_String()
        {
            var expected = "Two of Hearts"; 

            var card = new Card(Card.Suites.Hearts, Card.Ranks.Two).ToString();

            Assert.Equal(expected, card);
        }
    }
}
